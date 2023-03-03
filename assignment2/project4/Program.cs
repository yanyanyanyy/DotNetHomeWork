using System;


namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] datas = new int[,]
            {
                { 1, 2, 3, 4},
                { 5, 1, 2, 3},
                { 9, 5, 1, 2},
            };
            Console.WriteLine("当前测试矩阵为：");
            for (int i = 0; i < datas.GetLength(0); i++)
            {
                for (int j = 0; j < datas.GetLength(1); j++)
                {
                    Console.Write(datas[i, j]+",");
                }
                Console.WriteLine();
            }
            if(isP(datas))
            {
                Console.WriteLine("这个矩阵是托普利茨矩阵 ");
            }
            else
            {
                Console.WriteLine("这个矩阵不是托普利茨矩阵 ");
            }
            Console.ReadKey();
        }
        static bool isP(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0)-2; i++)//遍历行
            {
                int j = 0;
                if (a[i,j] != a[i + 1,j + 1])
                {
                    return false;
                }
                j++;
            }
            for (int i = 1; i < a.GetLength(1)-2; i++)//遍历列
            {
                int j = 0;
                if (a[j, i] != a[j + 1, i + 1])
                {
                    return false;
                }
                j++;
            }
            return true;
        }
    }
}
