namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Form2();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Form3();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newform = new Form4();
            newform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
