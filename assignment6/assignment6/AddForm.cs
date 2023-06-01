using System;
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
    public partial class AddForm : Form
    {

        Order order = new Order();
        OrderService service;
        BindingSource source;
        public AddForm()
        {
            InitializeComponent();
            orderDetailBindingSource.DataSource = order.Details;
        }
        public AddForm(OrderService orderService,BindingSource source)
        {
            service = orderService;
            this.source = source;
            InitializeComponent();
            orderDetailBindingSource.DataSource = order.Details;
        }
        private void AddGoodBtn_Click(object sender, EventArgs e)
        {
            string name = this.GoodName.Text;
            double price = Convert.ToDouble(this.goodPrice.Text);
            string id = this.GoodId.Text;
            int num = Convert.ToInt32(this.goodNum.Text);
            order.AddItem(new OrderDetail(order.Details.Count(),new Goods(id,name,price),num));
            orderDetailBindingSource.ResetBindings(true);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(detailsGrid.CurrentRow.Cells[0].Value);
            if(count >= 0) { order.Details.RemoveAt(count); }
            orderDetailBindingSource.ResetBindings(true);
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            service.AddOrder(order);
            order.OrderId = Convert.ToInt32(this.OrderId.Text);
            this.source.ResetBindings(true);
            order.Customer = new Customer(this.userIDBox.Text, this.userNameBox.Text);
            Close();
        }

    }
}
