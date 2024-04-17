namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Text = "";
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateValue();
        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateValue();
        }

        private void UpdateValue()
        {
            // Check if text boxes contain numeric values 
            if (IsANumber(textBox1.Text) && IsANumber(textBox2.Text))
            {
                // Create rectangle object and set sides
                var r = new Rectangle();
                r.SetSideA(textBox1.Text);
                r.SetSideB(textBox2.Text);

                // Display area
                label1.Text = r.GetArea().ToString();
            }
        }

        public bool IsANumber(string s)
        {
            return double.TryParse(s, out _);
        }

    }
}
