using System;

namespace Ordersystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(1, "pen", "a", 10);
            Order order2 = new Order(2, "ball", "a", 10);
            Order order3 = new Order(3, "pen", "b", 10);
            Order order4 = new Order(4, "phone", "c", 10);
            Order order5 = new Order(5, "book", "c", 10);
            Order order6 = new Order(6, "pen", "c", 10);

            OrderList testlist=new OrderList();
            testlist.Add(order1);
            testlist.Add(order3);
            testlist.Add(order4);
            testlist.Add(order2);
            testlist.showOrders();
            Console.WriteLine();
            testlist.Sort();
            testlist.showOrders();
            Console.WriteLine();
            testlist.sub(3);
            testlist.showOrders();
        }
    }
}
