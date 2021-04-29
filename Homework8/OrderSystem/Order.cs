using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{
    public class Order
    {
        public int number { get; set; }
        public String name { get; set; }
        public String customer { get; set; }
        public int price { get; set; }

        public Order() { }
        public Order(int a, string b, string c, int d)
        {
            this.number = a;
            this.name = b;
            this.customer = c;
            this.price = d;
        }
        public void ShowOrder()
        {
            Console.WriteLine("\n订单编号为:" + number + " 商品名称为：" + name + " 顾客为：" + customer + "订单金额为：" + price);
        }
    }
}
