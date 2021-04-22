using System;

namespace IsToplitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入待判断矩阵的行和列数");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];

            Console.WriteLine("请以此输入矩阵的值");
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    array[j, i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("已完成第{0}行的输入", i + 1);
            }

            bool isToplitz = true;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; i + j < a; ++j)
                {
                    if (array[0, i] != array[j, i + j]) { isToplitz = false; }
                }
            }
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; i + j < b; ++j)
                {
                    if (array[i, 0] != array[j + i, j]) { isToplitz = false; }
                }
            }

            if (isToplitz) { Console.WriteLine("该矩阵是托普利兹矩阵"); } else { Console.WriteLine("该矩阵不是托普利兹矩阵"); }
        }
    }
}
