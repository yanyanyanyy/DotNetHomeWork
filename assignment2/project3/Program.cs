using System;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] unEval = new bool[100];
            Console.WriteLine("2-100内的质数为:");
            for(int i = 2; i <= 100; i++) {
                for(int j = 2; j <= 100/i; j++)
                {
                    unEval[i * j-1] = true;
                }
            }
            for(int i = 1; i < 100; i++)
            {
                if (unEval[i] == false)
                {
                    Console.Write(i+1+",");
                }
            }
            Console.ReadKey();
        }
    }
}
