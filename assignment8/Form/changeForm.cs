﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace assignment6
{
    public partial class changeForm : Form
    {
        Order order;
        OrderService service;
        BindingSource source;
        public changeForm(OrderService orderService, BindingSource source, Order order)
        {
            service = orderService;
            this.source = source;
            this.order = order;
            InitializeComponent();
            orderDetailBindingSource.DataSource = order.Details;
        }

        private void changeGoodBtn_Click(object sender, EventArgs e)
        {
            OrderDetail detail = order.Details.ElementAt(detailsGrid.CurrentRow.Index); 
            string name;
            if(this.GoodName.Text != "")
            {
                name = this.GoodName.Text;
            }
            else
            {
                name = detail.GoodsName;
            }
            double price;
            if (this.goodPrice.Text != "") {
                price = Convert.ToDouble(this.goodPrice.Text);
            }
            else
            {
                price = detail.UnitPrice;
            }
            
            int num;
            if (this.goodNum.Text != "")
            {
                num = Convert.ToInt32(this.goodNum.Text);
            }
            else
            {
                num = detail.Quantity;
            }
            int index = detail.Index;
            order.RemoveDetail(detail); 
            
            order.AddItem(new OrderDetail(index, new Goods(name, price), num));
            orderDetailBindingSource.ResetBindings(true);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            if (this.userNameBox.Text != "")
            {
                order.Customer = new Customer(this.userNameBox.Text);
            }
            service.UpdateOrder(order);
            this.source.ResetBindings(true);
            Close();
        }
    }
}
