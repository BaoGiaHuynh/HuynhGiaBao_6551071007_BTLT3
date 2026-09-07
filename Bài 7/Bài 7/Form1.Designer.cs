namespace Bài_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            picLight = new PictureBox();
            btnTurnOff = new Button();
            lblDesigned = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picLight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 52);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "JACK";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // picLight
            // 
            picLight.BorderStyle = BorderStyle.FixedSingle;
            picLight.Image = Properties.Resources.OIP;
            picLight.Location = new Point(373, 138);
            picLight.Name = "picLight";
            picLight.Size = new Size(125, 98);
            picLight.SizeMode = PictureBoxSizeMode.StretchImage;
            picLight.TabIndex = 2;
            picLight.TabStop = false;
            picLight.Click += picLight_Click;
            // 
            // btnTurnOff
            // 
            btnTurnOff.BackColor = Color.Cyan;
            btnTurnOff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTurnOff.Location = new Point(265, 278);
            btnTurnOff.Name = "btnTurnOff";
            btnTurnOff.Size = new Size(322, 54);
            btnTurnOff.TabIndex = 3;
            btnTurnOff.Text = "Jack. Turn Off the Light ,please!";
            btnTurnOff.UseVisualStyleBackColor = false;
            btnTurnOff.Click += btnTurnOff_Click;
            // 
            // lblDesigned
            // 
            lblDesigned.AutoSize = true;
            lblDesigned.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDesigned.Location = new Point(265, 378);
            lblDesigned.Name = "lblDesigned";
            lblDesigned.Size = new Size(222, 20);
            lblDesigned.TabIndex = 4;
            lblDesigned.Text = "Designed by : ___________________";
            lblDesigned.Click += lblDesigned_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Cyan;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnExit.FlatAppearance.BorderSize = 3;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(559, 362);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(lblDesigned);
            Controls.Add(btnTurnOff);
            Controls.Add(picLight);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "frmLight";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picLight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox picLight;
        private Button btnTurnOff;
        private Label lblDesigned;
        private Button btnExit;
    }
}
