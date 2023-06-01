using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;
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
            if(this.GoodName.Text=="" || this.goodPrice.Text == "" || this.goodNum.Text == "")
            {
                return;
            }
            string name = this.GoodName.Text;
            double price = Convert.ToDouble(this.goodPrice.Text);
            int num = Convert.ToInt32(this.goodNum.Text);
            order.AddItem(new OrderDetail(order.Details.Count(),new Goods(name,price),num));
            orderDetailBindingSource.ResetBindings(true);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            detailsGrid.Rows.RemoveAt(detailsGrid.CurrentRow.Index);
            orderDetailBindingSource.ResetBindings(true);
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            
            order.Customer = new Customer(this.userNameBox.Text);
            service.AddOrder(order);
            this.source.ResetBindings(false);
            Close();
        }

    }
}
