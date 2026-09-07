namespace WinFormsApp2
{
    partial class hello
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
            txtNhap = new TextBox();
            label1 = new Label();
            button3 = new Button();
            txtHienthi = new TextBox();
            label2 = new Label();
            button1 = new Button();
            dong = new Button();
            SuspendLayout();
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(216, 93);
            txtNhap.Name = "txtNhap";
            txtNhap.PasswordChar = '*';
            txtNhap.Size = new Size(227, 27);
            txtNhap.TabIndex = 1;
            txtNhap.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 100);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Nhập password";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(127, 336);
            button3.Name = "button3";
            button3.Size = new Size(94, 41);
            button3.TabIndex = 4;
            button3.Text = "Hiển thị";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtHienthi
            // 
            txtHienthi.Location = new Point(218, 147);
            txtHienthi.Name = "txtHienthi";
            txtHienthi.Size = new Size(225, 27);
            txtHienthi.TabIndex = 6;
            txtHienthi.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 154);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Hiển thị";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(335, 336);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 8;
            button1.Text = "Tiếp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dong
            // 
            dong.BackColor = SystemColors.ActiveBorder;
            dong.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dong.Location = new Point(565, 336);
            dong.Name = "dong";
            dong.Size = new Size(94, 41);
            dong.TabIndex = 9;
            dong.Text = "Đóng";
            dong.UseVisualStyleBackColor = false;
            dong.Click += button2_Click;
            // 
            // hello
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dong);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtHienthi);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(txtNhap);
            Name = "hello";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNhap;
        private Label label1;
        private Button button3;
        private TextBox txtHienthi;
        private Label label2;
        private Button button1;
        private Button dong;
    }
}
