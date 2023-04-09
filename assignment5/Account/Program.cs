using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class MainClass
    {
        public static void Main()
        {
            try
            {
                Custmer customer1 = new Custmer(1, "Customer1");
                Custmer customer2 = new Custmer(2, "Customer2");

                Good good1 = new Good(1, "Good1", 10.0f);
                Good good2 = new Good(2, "Good2", 20.0f);
                Good good3 = new Good(3, "Good3", 30.0f);
                Good good4 = new Good(4, "Good4", 40.0f);
                Order order1 = new Order(1, DateTime.Now, customer1);
                order1.AddDetails(new OrderDetail(good1, 1));
                order1.AddDetails(new OrderDetail(good2, 2));

                Order order2 = new Order(2, DateTime.Now, customer2);
                order2.AddDetails(new OrderDetail(good3, 3));
                order2.AddDetails(new OrderDetail(good4, 4));

                OrderService orderService = new OrderService();
                orderService.AddOrder(order1);
                orderService.AddOrder(order2);

                Console.WriteLine("查询订单1\n" + orderService.SearchById(1));

                Console.WriteLine("查询用户2:");
                orderService.SearchByCustomerName("Customer2").ForEach(o=>Console.WriteLine(o));

                Console.ReadKey();
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
