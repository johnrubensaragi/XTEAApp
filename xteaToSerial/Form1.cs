using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace xteaToSerial
{
    public partial class Form1 : Form
    {
        const bool activateSerial = true;
        bool enc = false;
        int waitDuration = 10;
        int timeoutMilliseconds = 10; // 5 seconds, adjust as needed
        const string supportedExtensions = "*.jpg;*.jpeg;*.png;*.gif;*.bmp";
        string[] ports = System.IO.Ports.SerialPort.GetPortNames();
        int maxBlockSize = 64;//in bytes
        long i = 0;
        long fileSize = 0;
        FileStream inputFile;
        FileStream outputFile;
        SerialPort fpga;
        Encoding ourEncoding = Encoding.Default;

        public Form1()
        {
            InitializeComponent();
            portBox.Items.AddRange(ports);
            
        }

        private void showPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = !showPasswordBox.Checked;
            if (showPasswordBox.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
        }

        private void updateButton1()
        {
            if (checkBox1.Checked & encButton.Enabled) button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (activateSerial)
            {
                ports = System.IO.Ports.SerialPort.GetPortNames();
                portBox.Text = "";
                encButton.Enabled = false;
                decButton.Enabled = false;
                button1.Enabled = false;
                portBox.Items.Clear();
                portBox.Items.AddRange(ports);
            }
            else
            {
                encButton.Enabled = true;
                decButton.Enabled = true;
            }
        }

        private void portBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (openFileDialog.FileName != "" & portBox.Text != "" | !activateSerial)
            {
                encButton.Enabled = true;
                decButton.Enabled = true;
                updateButton1();
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = openFileDialog.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                if (portBox.Text != "" | !activateSerial)
                {
                    encButton.Enabled = true;
                    decButton.Enabled = true;
                }
                FileInfo fi = new FileInfo(openFileDialog.FileName);
                fileSize = fi.Length;
                sizeLabel.Text = fi.Length.ToString("#,##0") + " byte";
                trimBox.Value = (8 - (fileSize) % 8) % 8;
                if (fileSize != 1)
                {
                    sizeLabel.Text += "s";
                }
                
            }
        }

        static byte[] AddByteToEnd(byte[] originalArray, byte newByte)
        {
            byte[] newArray = new byte[originalArray.Length + 1];

            Array.Copy(originalArray, newArray, originalArray.Length);

            newArray[newArray.Length - 1] = newByte;

            return newArray;
        }

        private void sendOneBlock()
        {
            if (inputFile == null | !inputFile.CanRead)
            {
                inputFile = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
            }
            long blockSize;
            string inputSerial, outputSerial;
            inputSerial = "-m ";
            if (enc)
            {
                inputSerial += "0 ";
            }
            else
            {
                inputSerial += "1 ";
            }
            if (passwordBox.Text != "")
            {
                inputSerial += "-k " + passwordBox.Text + " ";
            }
            inputSerial += "-d ";
            if (fileSize - i > maxBlockSize)
            {
                blockSize = maxBlockSize;
            }
            else
            {
                blockSize = fileSize - i;
            }
            byte[] inputBlocks = new byte[blockSize];
            inputFile.Seek(i, SeekOrigin.Begin);
            inputFile.Read(inputBlocks, 0, Convert.ToInt32(blockSize));
            byte[] byteinputserial = ourEncoding.GetBytes(inputSerial).Concat(inputBlocks).ToArray();
            if (activateSerial)
            {
                fpga.Write(byteinputserial, 0, byteinputserial.Length);
            }
            inputBox.AppendText(ourEncoding.GetString(byteinputserial));
            byte[] outputBlocks = { };

            // Use Stopwatch to measure elapsed time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < timeoutMilliseconds)
            {
                byte[] newBlock = ourEncoding.GetBytes(fpga.ReadExisting());
                outputBlocks = outputBlocks.Concat(newBlock).ToArray();
                if (newBlock.Length > 0)
                {
                    stopwatch.Restart();
                }
            }
            outputBox.AppendText(ourEncoding.GetString(outputBlocks));
            if(!checkBox1.Checked) outputFile.Write(outputBlocks, 0, outputBlocks.Length);
            
        }

        private void sendAll()
        {

            DialogResult dialogresult = saveFileDialog.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                inputFile = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                outputFile = new FileStream(saveFileDialog.FileName, FileMode.Truncate, FileAccess.Write);
                outputFile.Close();
                outputFile = new FileStream(saveFileDialog.FileName, FileMode.Append, FileAccess.Write);
                if (activateSerial)
                {
                    if (fpga == null)
                    {
                        
                        fpga = new SerialPort();
                        fpga.PortName = portBox.Text;
                        fpga.BaudRate = int.Parse(baudBox.Text);
                        fpga.Parity = Parity.None;
                        fpga.DataBits = 8;
                        fpga.StopBits = StopBits.One;
                        fpga.Handshake = Handshake.None;
                        fpga.Encoding = ourEncoding;
                        fpga.Open();
                    }
                }
                progressBar1.Maximum = (int)fileSize;
                for (; i < fileSize; i += maxBlockSize)
                {
                    sendOneBlock();
                    progressBar1.Value = (int)i;
                }
                inputFile.Close();
                outputFile.Close();
                if (!enc)
                {
                    using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Open, FileAccess.ReadWrite))
                    {
                        // Get the current length of the file
                        long currentLength = fileStream.Length;

                        // Calculate the position to start cutting from
                        long newPosition = Math.Max(0, currentLength - (int)trimBox.Value);

                        // Set the position in the file stream
                        fileStream.Seek(newPosition, SeekOrigin.Begin);

                        // Truncate the file to the new position
                        fileStream.SetLength(newPosition);
                    }
                }
            }
        }
        private void encButton_Click(object sender, EventArgs e)
        {
            i = 0;
            enc = true;
            if (!checkBox1.Checked) sendAll();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            outputBox.Text = "";
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            i = 0;
            enc = false;
            if (!checkBox1.Checked) sendAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i >= fileSize) i = 0;
            sendOneBlock();
            i += maxBlockSize;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (encButton.Enabled)
            {
                updateButton1();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
     
            maxBlockSize = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            waitDuration = (int) numericUpDown2.Value;
            timeoutMilliseconds = (int) numericUpDown2.Value;
        }
    }
}
