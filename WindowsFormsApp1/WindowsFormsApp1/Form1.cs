using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string f, s;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            f = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToDouble(f) + Convert.ToDouble(s)).ToString();
            textBox2.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToDouble(f) - Convert.ToDouble(s)).ToString();
            textBox2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (s != "0")
            {
                textBox1.Text = (Convert.ToDouble(f) / Convert.ToDouble(s)).ToString();
                textBox2.Text = "0";
            }
            else
            {
                textBox1.Text="Cannot perform Operation";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToDouble(f) * Convert.ToDouble(s)).ToString();
            textBox2.Text = "0";
        }
    }
}
