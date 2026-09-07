namespace WinFormsApp2
{
    public partial class hello : Form
    {
        public hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            txtHienthi.Text = txtNhap.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtHienthi.Clear();
            txtNhap.Clear();

            
            txtNhap.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtHienthi.Text = txtNhap.Text;
        }
    }
}
