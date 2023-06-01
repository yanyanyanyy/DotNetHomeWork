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
    public partial class MainApp : Form
    {
        OrderService orderService = new OrderService();
        public String Keyword { get; set; }
        public MainApp()
        {
            InitializeComponent();
            orderService = new OrderService();
            orderBindingSource.DataSource = orderService.Orders;
            cbxField.SelectedIndex = 0;
            queryKeyword.DataBindings.Add("Text", this, "Keyword");
        }
       

        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cbxField.SelectedIndex)
            {
                case 0:
                    orderBindingSource.DataSource = orderService.Orders;
                    break;
                case 1:
                    
                    Order order = orderService.GetOrder(Keyword);
                    List<Order> result = new List<Order>();
                    if (order != null) result.Add(order);
                    orderBindingSource.DataSource = result;
                    break;
                case 2:
                    orderBindingSource.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                    break;
                case 3:
                    orderBindingSource.DataSource = orderService.QueryOrdersByGoodsName(Keyword);
                    break;
                
            }
            orderBindingSource.ResetBindings(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderDetailBindingSource.DataSource = orderService.GetOrder((string)orderGrid.CurrentRow.Cells[0].Value).Details;
            orderDetailBindingSource.ResetBindings(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            orderService.RemoveOrder((string)orderGrid.CurrentRow.Cells[0].Value);
            orderBindingSource.DataSource = orderService.Orders;
            orderDetailBindingSource.DataSource = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(this.orderService, orderBindingSource);
            form.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Order order = orderService.GetOrder((string)orderGrid.CurrentRow.Cells[0].Value);
            changeForm form = new changeForm(this.orderService, orderBindingSource, order);
            form.Show();
        }
    }
}
