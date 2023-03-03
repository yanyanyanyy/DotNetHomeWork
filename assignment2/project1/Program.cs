using System;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数:");
            int num = int.Parse(Console.ReadLine());
            bool is_eval;
            for(int i = 2; i <= num; i++)
            {
                is_eval = false;
                if(num % i == 0){//若i是num的因子
                    is_eval = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)//判断是否为质数
                    {
                        if (i % j == 0)//若i不为质数
                        {
                            is_eval = false;
                            break;
                        }
                    } 
                }
                if (is_eval)
                {
                    Console.Write(""+i+",");
                }
            }
            Console.ReadKey(true);
        }
    }
}
