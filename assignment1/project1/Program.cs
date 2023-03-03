using System;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个操作数:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个操作数:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入操作符:");
            int op = Console.Read();

            if (op == '+')
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == '-')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == '/') 
            { 
                Console.WriteLine(num1 / num2);
            }
            Console.ReadKey();
        }
    }
}
