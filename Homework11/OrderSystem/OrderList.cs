using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderSystem
{
    public class OrderList
    {
        public List<Order> Orders = new List<Order>();

        public OrderList() { }
        public void Sort()
        {
            Orders.Sort((p1, p2) => p1.number - p2.number);
        }
        public void Add(Order order1)
        {
            Orders.Add(order1);
        }
        public void sub(int id)
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in Orders)
                {
                    i++;
                    if (order.number == id)
                    {
                        j = i;
                    }
                }
                Orders.RemoveAt(j);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("删除失败，请检查订单号!");
            }
        }
        public void modify(int id, Order neworder)
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in Orders)
                {
                    i++;
                    if (order.number == id)
                    {
                        j = i;
                    }
                }
                Orders[j] = neworder;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("修改失败，请检查订单号!");
            }
        }
        public Order getOrder(int id)
        {
            Order a = Orders.Find(p => p.number == id);
            return a;
        }
        public List<Order> querybyCus(String name)
        {
            var query = Orders.Where(o => o.customer == name).OrderBy(o => o.price);
            return query.ToList();
        }
        public List<Order> querybyName(String name)
        {
            var query = Orders.Where(o => o.name == name).OrderBy(o => o.price);
            return query.ToList();
        }
        public void showID()
        {
            foreach (Order order in Orders)
            {
                Console.Write(order.number + " ");
            }
        }
        public void showOrders()
        {
            foreach (Order order in Orders)
            {
                order.ShowOrder();
            }
        }
        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Orders);
            }
            Console.WriteLine("\nSerialized as xml");
            Console.WriteLine(File.ReadAllText("orderlist.xml"));
        }
        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Open))
            {
                Orders = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from orderlist.xml");
            }
        }
    }
}
