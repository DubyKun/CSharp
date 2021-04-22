using System;

namespace GetParameterInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("请输入长度为{0}的数组", n);

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0], min = array[0], res = array[0];
            double ave;

            for (int i = 1; i < n; i++)
            {
                if (array[i] > max) { max = array[i]; }
                if (array[i] < min) { min = array[i]; }
                res = res + array[i];
            }
            ave = res / n;

            Console.WriteLine("最大值为{0}，最小值为{1}，数组和为{2}，平均数为{3}", max, min, res, ave);

        }
    }
}
