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
        Form1 form1;
        public Form2()
        {
            form1 = (Form1)this.Owner;
            InitializeComponent();
        }
        public Form2(Order order,Form1 form)
        {
            InitializeComponent();
            form1 = form;
            textBox1.Text = Convert.ToString(order.number);
            textBox2.Text = order.name;
            textBox3.Text = order.customer;
            textBox4.Text = Convert.ToString(order.price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
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