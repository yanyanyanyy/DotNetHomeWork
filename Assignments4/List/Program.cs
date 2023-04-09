using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (Node<T> n = head; n != null; n = n.Next)
            {
                action(n.Data);
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            list.ForEach(n => Console.Write(n + "\a;"));
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            list.ForEach(n => {min = (n < min) ? n : min;});
            list.ForEach(n => {max = (n > max) ? n : min; });
            list.ForEach(n => { sum = sum + n; });
            Console.WriteLine($"Min:{min},Max:{max},Sum:{sum}");
            Console.ReadKey();
        }
    }
}
