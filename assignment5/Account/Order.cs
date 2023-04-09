using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class Order
    {
        public List<OrderDetail> Details { get; set; }
        public int Id { get; set; }
        public Custmer Custmer { get; set; }

        public DateTime CreateTime { get; set; }

        public Order(int orderId, DateTime creatTime,Custmer custmer)
        {
            Details = new List<OrderDetail>();
            Id = orderId;
            CreateTime = creatTime;
            Custmer = custmer;
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            if (Details.Contains(orderDetail))
            {
                throw new ApplicationException(orderDetail + "已经存在");
            }
            else { Details.Add(orderDetail); }
        }

        public void RemoveDetails(int num)
        {
            Details.RemoveAt(num);
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && Id == order.Id;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"orderId:{Id}");
            Details.ForEach(detail => result.Append("\n" + detail));
            return result.ToString();
        }
    }
}
