using Org.BouncyCastle.Asn1.X509;
using Remotion.Linq.Clauses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{

    /**
     * The service class to manage orders
     * */
    public class OrderService
    {

        public OrderService()
        {
            using (var ctx = new OrderContext())
            {
                if (ctx.Goods.Count() == 0)
                {
                    ctx.Goods.Add(new Goods("apple", 100.0));
                    ctx.Goods.Add(new Goods("egg", 200.0));
                    ctx.SaveChanges();
                }
                if (ctx.Customers.Count() == 0)
                {
                    ctx.Customers.Add(new Customer("li"));
                    ctx.Customers.Add(new Customer("zhang"));
                    ctx.SaveChanges();
                }
            }
        }

        public List<Order> Orders
        {
            get
            {
                using (var ctx = new OrderContext())
                {
                    List<Order> order = ctx.Orders
                      .Include(o => o.Details.Select(d => d.GoodsItem))
                      .Include(o => o.Customer)
                      .ToList<Order>();
                    return order;
                }
            }
        }
        //通过id获取订单
        public Order GetOrder(string id)
        {
            using (var ctx = new OrderContext())
            {
                return ctx.Orders
                  .Include(o => o.Details.Select(d => d.GoodsItem))
                  .Include(o => o.Customer)
                  .SingleOrDefault(o => o.OrderId == id);
            }
        }
        //添加订单
        public void AddOrder(Order order)
        {
            
            using (var ctx = new OrderContext())
            {

                order.CustomerId = order.Customer.Id;
                order.Details.ForEach(d => {
                    d.GoodsId = d.GoodsItem.Id;
                    if (!ctx.Goods.Any(o => o.Id == d.GoodsId))
                        ctx.Goods.Add(d.GoodsItem);
                    else
                    {
                        Goods good = ctx.Goods.FirstOrDefault(o => o.Id == d.GoodsId);
                        if (good.Name != d.GoodsName || good.Price != d.UnitPrice)
                        {
                            good.Name = d.GoodsName;
                            good.Price = d.UnitPrice;
                        }
                        else
                        {
                            d.GoodsItem = null;
                        }
                    }
                    if (!ctx.OrderDetails.Any(o => o.Id == d.Id))
                        ctx.OrderDetails.Add(d);
                    
                    if (QueryOrdersByGoodsName(d.GoodsName).Count () > 0) { }
                });
                if (!ctx.Customers.Any(o => o.Id == order.Customer.Id))
                    ctx.Customers.Add(order.Customer);
                
                else
                {
                    Customer customer = ctx.Customers.FirstOrDefault(o => o.Id == order.Customer.Id);
                    if (customer.Name != order.CustomerName)
                        customer.Name = order.CustomerName;
                    else
                    {
                        order.Customer = null;
                    }
                }
                
                if (!ctx.Orders.Any(o => o.OrderId == order.OrderId))
                    ctx.Orders.Add(order);
                ctx.SaveChanges();

            }
        }
        //删除订单
        public void RemoveOrder(string orderId)
        {
            using (var ctx = new OrderContext())
            {
                var order = ctx.Orders.Include("Details")
                  .SingleOrDefault(o => o.OrderId == orderId);
                if (order == null) return;
                ctx.OrderDetails.RemoveRange(order.Details);
                ctx.Orders.Remove(order);
                ctx.SaveChanges();
            }
        }
        //通过商品名查询订单
        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            using (var ctx = new OrderContext())
            {
                return ctx.Orders
                  .Include(o => o.Details.Select(d => d.GoodsItem))
                  .Include(o => o.Customer)
                  .Where(order => order.Details.Any(item => item.GoodsItem.Name == goodsName))
                  .ToList();
            }
        }
        //根据客户名查询
        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using (var ctx = new OrderContext())
            {
                return ctx.Orders
                  .Include(o => o.Details.Select(d => d.GoodsItem))
                  .Include(o => o.Customer)
                  .Where(order => order.Customer.Name == customerName)
                  .ToList();
            }
        }
        //更新订单
        public void UpdateOrder(Order newOrder)
        {
            RemoveOrder(newOrder.OrderId);
            AddOrder(newOrder);
        }


    }
}
