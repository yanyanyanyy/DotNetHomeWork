using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 1, 2, 3, 4, 5, 6 };
            getInf(testArr);
        }

        static void getInf(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            Console.Write("数组值为：");
            foreach(int d in arr)
            {
                if(d < min)
                {
                    min = d;
                }
                if(d > max)
                {
                    max = d;
                }
                sum += d;
                Console.Write(""+d+",");
            }
            Console.WriteLine();
            Console.WriteLine("数组最大值为:" + max);
            Console.WriteLine("数组最小值为:" + min);
            Console.WriteLine("数组平均值为:" + sum/arr.Length);
            Console.WriteLine("数组总和为: " + sum );
            Console.ReadKey(true);
        }
    }
}
