using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form2 : Form
    {
        public Order orderT = new Order();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Order order)
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", order, "OrderId");
            textBox2.DataBindings.Add("Text", order, "Name");
            textBox3.DataBindings.Add("Text", order, "Customer");
            textBox4.DataBindings.Add("Text", order, "Price");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            Order order1 = new Order(int.Parse(textBox1.Text),textBox2.Text,textBox3.Text,int.Parse(textBox4.Text));

            if (form1.os.Orders.Contains(order1))
            {
                form1.os.modify(order1.number, order1);
            }
            else
            {
                form1.os.Add(order1);
                form1.os.Sort();
            }
            this.Close();
        }
    }
}