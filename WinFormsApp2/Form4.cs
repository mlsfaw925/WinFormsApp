using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateHELLO();
        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateHELLO();
        }

        private void UpdateHELLO()
        {
            if (IsANumber(textBox1.Text) && IsANumber(textBox2.Text))
            {

                var t = new Triangle();
                t.SetSideA(textBox1.Text);
                t.SetSideB(textBox2.Text);

                label1.Text = t.Pythagoras().ToString();
            }
        }

        public bool IsANumber(string s)
        {
            return double.TryParse(s, out _);
        }
//d
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsANumber(textBox1.Text) && IsANumber(textBox2.Text))
            {

                var t = new Triangle();
                t.SetSideA(textBox1.Text);
                t.SetSideB(textBox2.Text);

                label1.Text = t.Pythagoras().ToString();
                label4.Text = t.GetArea().ToString();
            }
        }
    }
}
