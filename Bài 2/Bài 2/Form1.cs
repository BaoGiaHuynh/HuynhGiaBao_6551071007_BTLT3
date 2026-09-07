namespace Bài_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã click!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Hi , Welcome to C# 2010 programming!");

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã click form!");
        }
    }
}
