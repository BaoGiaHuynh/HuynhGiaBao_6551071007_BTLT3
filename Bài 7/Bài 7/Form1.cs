using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bài_7
{
    public partial class Form1 : Form
    {
        // Khai báo component ToolTip để hiển thị chú thích khi rê chuột vào ảnh
        private ToolTip toolTip1 = new ToolTip();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1a. Form hiển thị ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1d. Tên mặc định ban đầu
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Jack";
            }

            // 1c. Trạng thái ban đầu: Đèn SÁNG (picLight hiện, picTurnOff ẩn)
            picLight.Visible = true;

            // Thiết lập ToolTip gợi ý khi rê chuột vào hình bóng đèn sáng
            toolTip1.SetToolTip(picLight, "Click me to Turn OFF the Light!");

            // 1e. Cập nhật dòng chữ bên dưới bóng đèn
            CapNhatThongBao();
        }

        // Hàm cập nhật dòng thông báo theo tên và trạng thái bóng đèn
        private void CapNhatThongBao()
        {
            string ten = string.IsNullOrWhiteSpace(textBox1.Text) ? "Jack" : textBox1.Text;

            if (picLight.Visible)
            {
                // Khi đèn đang SÁNG -> Nhắc tắt đèn
                btnTurnOff.Text = ten + ". Turn Off the Light ,please!";
            }
            else
            {
                // Khi đèn đang TẮT -> Nhắc mở đèn
                btnTurnOff.Text = ten + ". Turn On the Light ,please!";
            }
        }

        // 1d. Khi nhập/thay đổi tên trong TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CapNhatThongBao();
        }

        // 2. Khi người dùng Click vào PictureBox (chuyển đổi trạng thái Sáng <-> Tắt)
        private void picLight_Click(object sender, EventArgs e)
        {
            DoiTrangThaiBongDen();
        }

        // Nút bấm bên dưới cũng cho phép chuyển đổi Sáng <-> Tắt khi Click
        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            DoiTrangThaiBongDen();
        }

        // Hàm đổi trạng thái hiển thị bóng đèn
        private void DoiTrangThaiBongDen()
        {
            // Đảo ngược trạng thái ẩn/hiện
            picLight.Visible = !picLight.Visible;

            // Cập nhật lại ToolTip tương ứng
            if (picLight.Visible)
            {
                toolTip1.SetToolTip(picLight, "Click me to Turn OFF the Light!");
            }
            else
            {
                toolTip1.SetToolTip(picLight, "Click me to Turn ON the Light!");
            }

            // Cập nhật lại thông báo
            CapNhatThongBao();
        }

        // 3. Nút Exit đóng ứng dụng
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Các hàm không dùng đến có thể giữ nguyên
        private void label1_Click(object sender, EventArgs e) { }
        private void lblDesigned_Click(object sender, EventArgs e) { }
    }
}