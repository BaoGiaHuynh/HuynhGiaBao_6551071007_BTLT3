namespace Bài_3
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
            lblHoTen = new Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            lbHo = new Label();
            lbTen = new Label();
            btnHo = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.CornflowerBlue;
            lblHoTen.ForeColor = SystemColors.ButtonHighlight;
            lblHoTen.Location = new Point(2, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(797, 97);
            lblHoTen.TabIndex = 0;
            lblHoTen.UseVisualStyleBackColor = false;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(232, 117);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(484, 27);
            txtHo.TabIndex = 1;
            txtHo.TextChanged += txtHo_TextChanged;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.MistyRose;
            txtTen.Location = new Point(232, 191);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(484, 27);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // lbHo
            // 
            lbHo.AutoSize = true;
            lbHo.Location = new Point(141, 124);
            lbHo.Name = "lbHo";
            lbHo.Size = new Size(29, 20);
            lbHo.TabIndex = 3;
            lbHo.Text = "Họ";
            lbHo.Click += lbHo_Click;
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Location = new Point(141, 194);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(32, 20);
            lbTen.TabIndex = 4;
            lbTen.Text = "Tên";
            lbTen.Click += lbTen_Click;
            // 
            // btnHo
            // 
            btnHo.BackColor = SystemColors.ActiveBorder;
            btnHo.Location = new Point(141, 283);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 40);
            btnHo.TabIndex = 5;
            btnHo.Text = "Họ";
            btnHo.UseVisualStyleBackColor = false;
            btnHo.Click += btnHo_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(367, 283);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 6;
            button1.Text = "Tên";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(584, 283);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 7;
            button2.Text = "Họ và Tên";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Location = new Point(327, 368);
            button3.Name = "button3";
            button3.Size = new Size(177, 40);
            button3.TabIndex = 8;
            button3.Text = "Thoát chương trình";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnHo);
            Controls.Add(lbTen);
            Controls.Add(lbHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lblHoTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label lbHo;
        private Label lbTen;
        private Button btnHo;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
