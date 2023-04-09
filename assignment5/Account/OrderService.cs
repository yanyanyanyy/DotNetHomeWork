using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class OrderService
    {
        public List<Order> Orders { get; set; }

        public OrderService()
        {
            Orders = new List<Order>();
        }

        //添加订单
        public void AddOrder(Order order)
        {
            if (Orders.Contains(order))
            {
                throw new ApplicationException($"the order {order.Id} already exists!");
            }
            Orders.Add(order);
        }


        //根据Id删除订单
        public void RemoveOrder(int orderId)
        {
            Orders.RemoveAll(o => o.Id == orderId);
        }

        public Order SearchById(int orderId)
        {
            return Orders.FirstOrDefault(o => o.Id == orderId);
        }
        public List<Order> SearchByCustomerName(string customerName)
        {
            var query = Orders
                .Where(o => o.Custmer.Name == customerName);
            return query.ToList();
        }

        public List<Order> SearchByGoodsName(string goodsName)
        {
            var query = Orders.Where(
              o => o.Details.Any(d => d.Good.Name == goodsName));
            return query.ToList();

        }
    }
}
