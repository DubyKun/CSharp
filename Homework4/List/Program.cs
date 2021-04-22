using System;

namespace Project1
{
    class MyListNode<T>
    {
        public T value;
        public MyListNode<T> next;

        public MyListNode(T val, MyListNode<T> node) { this.value = val; next = node; }
        public MyListNode(T val) { this.value = val; next = null; }
        public void SetNext(MyListNode<T> node) { next = node; }
    }

    class MyList<T>
    {
        private int size = 0;
        private MyListNode<T> head;

        public MyList() { this.head = null; this.size = 0; }

        public void Add(T val)
        {
            MyListNode<T> node = new MyListNode<T>(val);
            node.next = this.head.next.next;
            this.head.next = node;
            size++;
        }

       // public T getMax()
       // {
        //    T max = head.next.value;
       //     MyListNode<T> p = head.next;
       //     for (int i = 0; i < size; i++)
      //      {
       //         if (p.value > max) { max = p.value; }
       //     }
       //     return max;
       // }
       // public T getMin()
       // {
       //     T min = head.next.value;
       //     MyListNode<T> p = head.next;
       //     for (int i = 0; i < size; i++)
       //     {
       //         if (p.value < min) { min = p.value; }
       //     }
       //     return min;
       // }
        public void forEach()
        {
            MyListNode<T> p = head.next;
            for (int i = 0; i < size; i++)
           {
                Console.WriteLine(p.value);
               p = p.next;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
