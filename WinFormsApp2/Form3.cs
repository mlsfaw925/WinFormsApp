using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class rectangleareaform : Form
    {
        public rectangleareaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var width = Convert.ToDouble(textBox1.Text);
            var length = Convert.ToDouble(textBox2.Text);
            label1.Text = Convert.ToString(width * length);

        }
    }
}
