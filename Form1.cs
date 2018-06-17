using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comboboxproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            label4.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if(Char.IsControl(e.KeyChar))
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    if(sender.Equals(textBox1))
                    {
                        textBox2.Focus();
                    }
                    else
                    {
                        comboBox1.Focus();
                    }
                }
                return;
            }
            e.Handled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v;
            double s;
            double price = 0;
            double sum;

            s = Convert.ToDouble(textBox1.Text);
            v = Convert.ToDouble(textBox2.Text);

            switch(comboBox1.SelectedIndex)
            {
                case 0: price = 70; break;
                case 1: price = 710; break;
                case 2: price = 50; break;
            }
            sum = (v * s) / 10000 * price;
            label4.Text = "Ölçü: " + s + "x" + v + "см. \n" + "Qiymət: (m./m.kv.): " + price.ToString("c") + "\nCəmi :" + sum.ToString("c");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
