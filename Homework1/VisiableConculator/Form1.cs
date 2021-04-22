using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisibleCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double a, b;
        Boolean test = false;
        char fu;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
            this.Text = "计算器";
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }


        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }


        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (test)
            {
                a = double.Parse(textBox1.Text);
                fu = '+';
                textBox4.Text = string.Format("{0}", fu);
            }
            else
            {
                textBox1.Text = textBox2.Text;
                a = double.Parse(textBox2.Text);
                fu = '+';
                textBox4.Text = string.Format("{0}", fu);
                textBox2.Text = null;
                test = true;
            }
        }



        private void button14_Click(object sender, EventArgs e)
        {
            if (test)
            {
                a = double.Parse(textBox1.Text);
                fu = '-';
                textBox4.Text = string.Format("{0}", fu);
            }
            else
            {
                textBox1.Text = textBox2.Text;
                a = double.Parse(textBox2.Text);
                fu = '-';
                textBox4.Text = string.Format("{0}", fu);
                textBox2.Text = null;
                test = true;
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (test)
            {
                a = double.Parse(textBox1.Text);
                fu = '*';
                textBox4.Text = string.Format("{0}", fu);
            }
            else
            {
                textBox1.Text = textBox2.Text;
                a = double.Parse(textBox2.Text);
                fu = '*';
                textBox4.Text = string.Format("{0}", fu);
                textBox2.Text = null;
                test = true;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (test)
            {
                a = double.Parse(textBox1.Text);
                fu = '/';
                textBox4.Text = string.Format("{0}", fu);
            }
            else
            {
                textBox1.Text = textBox2.Text;
                a = double.Parse(textBox2.Text);
                fu = '/';
                textBox4.Text = string.Format("{0}", fu);
                textBox2.Text = null;
                test = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox4.Text = null;
            a = 0; b = 0; fu = ' ';
            test = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox2.Text);
            switch (fu)
            {
                case '+':
                    a += b;
                    break;
                case '-':
                    a -= b;
                    break;
                case '*':
                    a *= b;
                    break;
                case '/':
                    a /= b;
                    break;
                default:
                    break;
            }
            textBox1.Text = a.ToString();
            textBox2.Text = null;
            textBox4.Text = null;
            fu = ' ';
            b = 0; a = 0;
        }

    }
}
