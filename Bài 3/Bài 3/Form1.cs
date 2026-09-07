namespace Bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nhấn vào Button btnHo thì gán nội dung của txtHo cho lblHoTen
        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        // Nhấn vào Button btnTen (button1) thì gán nội dung của txtTen cho lblHoTen
        private void button1_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        // Nhấn vào Button btnHoTen (button2) thì gán nội dung txtHo + " " + txtTen cho lblHoTen
        private void button2_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        // Nhấn vào btnKetThuc (button3) thì đóng chương trình
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Các hàm sự kiện trống không dùng đến có thể để nguyên
        private void lblHoTen_Click(object sender, EventArgs e) { }
        private void txtHo_TextChanged(object sender, EventArgs e) { }
        private void lbHo_Click(object sender, EventArgs e) { }
        private void lbTen_Click(object sender, EventArgs e) { }
        private void txtTen_TextChanged(object sender, EventArgs e) { }
    }
}