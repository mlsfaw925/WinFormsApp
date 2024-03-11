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
    public partial class squareareaform : Form
    {
        public squareareaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var side = Convert.ToDouble(textBox1.Text);
            label1.Text = Convert.ToString(side * side);
        }
    }
}
