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

            Order order = new Order(1, new Customer("1", "李四"), new List<OrderDetail>());
            order.AddItem(new OrderDetail(1, new Goods("1", "笔记本", 1000.0), 1));
            order.AddItem(new OrderDetail(2, new Goods("2", "鼠标", 100), 1));
            order.AddItem(new OrderDetail(3, new Goods("3", "键盘", 200), 1));
            orderService.AddOrder(order);
            Order order2 = new Order(2, new Customer("2", "张三"), new List<OrderDetail>());
            order2.AddItem(new OrderDetail(1, new Goods("2", "苹果", 5.0), 2));
            orderService.AddOrder(order2);
            orderBindingSource.DataSource = orderService.GetAllOrders();

           queryKeyword.DataBindings.Add("Text", this, "Keyword");
        }
       

        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cbxField.SelectedIndex)
            {
                case 0:
                    orderBindingSource.DataSource = orderService.GetAllOrders();
                    break;
                case 1:
                    int id = Convert.ToInt32(Keyword);
                    Order order = orderService.GetOrder(id);
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
                case 4:
                    float totalPrice = Convert.ToInt32(Keyword);
                    orderBindingSource.DataSource =
                           orderService.QueryByTotalAmount(totalPrice);
                    break;
            }
            orderBindingSource.ResetBindings(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(orderGrid.CurrentRow.Cells[0].Value);
            orderDetailBindingSource.DataSource = orderService.GetOrder(id).Details;
            orderDetailBindingSource.ResetBindings(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(orderGrid.CurrentRow.Cells[0].Value);
            if (count >= 0) { orderService.RemoveOrder(count); }
            orderBindingSource.ResetBindings(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(this.orderService, orderBindingSource);
            form.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(orderGrid.CurrentRow.Cells[0].Value);
            Order order = orderService.GetOrder(count);
            changeForm form = new changeForm(this.orderService, orderBindingSource, order);
            form.Show();
        }
    }
}
