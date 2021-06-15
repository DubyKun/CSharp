using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace OrderSystem
{


    public partial class Form1 : Form
    {
        public OrderList os = new OrderList();
        string fileName = @"./orders.xml";
        public Form1()
        {
            InitializeComponent();
            Data1.DataSource = os.Orders;

            Order order1 = new Order(1, "a", "x", 10);
            os.Add(order1);
            Order order2 = new Order(2, "b", "y", 10);
            os.Add(order2);
            Order order3 = new Order(3, "c", "z", 10);
            os.Add(order3);
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            Form2 form2 = new Form2(order,this);
            form2.Show(this);
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            Order order = os.getOrder(int.Parse(OrderNum.Text));
            Form2 form2 = new Form2(order,this);
            form2.Show(this);
        }

        private void Subbutton_Click(object sender, EventArgs e)
        {
            if (OrderNum.Text == null) return;
            os.sub(int.Parse(OrderNum.Text));
        }

        private void Inportbutton_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!os.Orders.Contains(order))
                    {
                        os.Orders.Add(order);
                    }
                });
            }
        }

        private void Exportbutton_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, os.Orders);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                Data2.DataSource = os.Orders;
            }
            else
            {
                Data2.DataSource = os.querybyName(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                Data2.DataSource = os.Orders;
            }
            else
            {
                Data2.DataSource = os.querybyCus(textBox1.Text);
            }
        }
    }
}
