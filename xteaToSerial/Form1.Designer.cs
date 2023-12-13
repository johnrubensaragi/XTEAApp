namespace xteaToSerial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.baudBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.encButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.decButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showPasswordBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trimBox = new System.Windows.Forms.NumericUpDown();
            this.refreshButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.autoScrollBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trimBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(149, 31);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial baud rate:";
            // 
            // baudBox
            // 
            this.baudBox.FormattingEnabled = true;
            this.baudBox.Items.AddRange(new object[] {
            "1200",
            "9600",
            "115200",
            "230400",
            "2000000"});
            this.baudBox.Location = new System.Drawing.Point(103, 57);
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(121, 21);
            this.baudBox.TabIndex = 2;
            this.baudBox.Text = "115200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Size:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.Location = new System.Drawing.Point(67, 36);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(76, 13);
            this.sizeLabel.TabIndex = 4;
            this.sizeLabel.Text = "Unknown";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time Estimate:";
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(87, 115);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(134, 13);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Unknown";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 285);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port:";
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(149, 6);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(75, 21);
            this.portBox.TabIndex = 9;
            this.portBox.SelectedIndexChanged += new System.EventHandler(this.portBox_SelectedIndexChanged);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.inputBox.Location = new System.Drawing.Point(230, 31);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(258, 246);
            this.inputBox.TabIndex = 10;
            // 
            // encButton
            // 
            this.encButton.Enabled = false;
            this.encButton.Location = new System.Drawing.Point(15, 254);
            this.encButton.Name = "encButton";
            this.encButton.Size = new System.Drawing.Size(75, 23);
            this.encButton.TabIndex = 11;
            this.encButton.Text = "Encrypt";
            this.encButton.UseVisualStyleBackColor = true;
            this.encButton.Click += new System.EventHandler(this.encButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Key:";
            // 
            // decButton
            // 
            this.decButton.Enabled = false;
            this.decButton.Location = new System.Drawing.Point(146, 254);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(75, 23);
            this.decButton.TabIndex = 13;
            this.decButton.Text = "Decrypt";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(122, 84);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(102, 20);
            this.passwordBox.TabIndex = 14;
            this.passwordBox.Text = "password12345678";
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.outputBox.Location = new System.Drawing.Point(515, 31);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(260, 246);
            this.outputBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Input:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output:";
            // 
            // showPasswordBox
            // 
            this.showPasswordBox.AutoSize = true;
            this.showPasswordBox.Location = new System.Drawing.Point(47, 86);
            this.showPasswordBox.Name = "showPasswordBox";
            this.showPasswordBox.Size = new System.Drawing.Size(53, 17);
            this.showPasswordBox.TabIndex = 18;
            this.showPasswordBox.Text = "Show";
            this.showPasswordBox.UseVisualStyleBackColor = true;
            this.showPasswordBox.CheckedChanged += new System.EventHandler(this.showPasswordBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Trim ... byte(s) off output file:";
            // 
            // trimBox
            // 
            this.trimBox.Location = new System.Drawing.Point(171, 139);
            this.trimBox.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.trimBox.Name = "trimBox";
            this.trimBox.Size = new System.Drawing.Size(53, 20);
            this.trimBox.TabIndex = 20;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(87, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 23);
            this.refreshButton.TabIndex = 22;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(286, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // autoScrollBox
            // 
            this.autoScrollBox.AutoSize = true;
            this.autoScrollBox.Location = new System.Drawing.Point(367, 10);
            this.autoScrollBox.Name = "autoScrollBox";
            this.autoScrollBox.Size = new System.Drawing.Size(77, 17);
            this.autoScrollBox.TabIndex = 24;
            this.autoScrollBox.Text = "Auto Scroll";
            this.autoScrollBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Send Per Block";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(142, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Send 1 block";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Block Size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(146, 194);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(146, 220);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown2.TabIndex = 29;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Timeout Duration (ms)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 320);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.autoScrollBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.trimBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.showPasswordBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baudBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trimBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button encButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox showPasswordBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown trimBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox autoScrollBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label10;
    }
}

