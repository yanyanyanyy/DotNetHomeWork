namespace assignment6
{
    partial class MainApp
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detailGrid = new System.Windows.Forms.DataGridView();
            this.ObjectIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.OrderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.functionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.queryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxField = new System.Windows.Forms.ComboBox();
            this.queryKeyword = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.functionPanel.SuspendLayout();
            this.queryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.functionPanel);
            this.mainPanel.Controls.Add(this.queryPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1156, 704);
            this.mainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.detailGrid);
            this.panel1.Controls.Add(this.orderGrid);
            this.panel1.Location = new System.Drawing.Point(8, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 616);
            this.panel1.TabIndex = 3;
            // 
            // detailGrid
            // 
            this.detailGrid.AllowDrop = true;
            this.detailGrid.AllowUserToAddRows = false;
            this.detailGrid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.detailGrid.AutoGenerateColumns = false;
            this.detailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.detailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjectIdColumn,
            this.ObjectNameColumn,
            this.ObjectNumColumn,
            this.ObjectPriceColumn});
            this.detailGrid.DataSource = this.orderDetailBindingSource;
            this.detailGrid.Location = new System.Drawing.Point(549, 3);
            this.detailGrid.Name = "detailGrid";
            this.detailGrid.RowHeadersWidth = 51;
            this.detailGrid.RowTemplate.Height = 27;
            this.detailGrid.Size = new System.Drawing.Size(591, 610);
            this.detailGrid.TabIndex = 1;
            // 
            // ObjectIdColumn
            // 
            this.ObjectIdColumn.DataPropertyName = "Index";
            this.ObjectIdColumn.HeaderText = "货物号";
            this.ObjectIdColumn.MinimumWidth = 6;
            this.ObjectIdColumn.Name = "ObjectIdColumn";
            // 
            // ObjectNameColumn
            // 
            this.ObjectNameColumn.DataPropertyName = "GoodsName";
            this.ObjectNameColumn.HeaderText = "货物名";
            this.ObjectNameColumn.MinimumWidth = 6;
            this.ObjectNameColumn.Name = "ObjectNameColumn";
            this.ObjectNameColumn.ReadOnly = true;
            // 
            // ObjectNumColumn
            // 
            this.ObjectNumColumn.DataPropertyName = "Quantity";
            this.ObjectNumColumn.HeaderText = "数量";
            this.ObjectNumColumn.MinimumWidth = 6;
            this.ObjectNumColumn.Name = "ObjectNumColumn";
            // 
            // ObjectPriceColumn
            // 
            this.ObjectPriceColumn.DataPropertyName = "UnitPrice";
            this.ObjectPriceColumn.HeaderText = "单价";
            this.ObjectPriceColumn.MinimumWidth = 6;
            this.ObjectPriceColumn.Name = "ObjectPriceColumn";
            this.ObjectPriceColumn.ReadOnly = true;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(OrderApp.OrderDetail);
            // 
            // orderGrid
            // 
            this.orderGrid.AllowDrop = true;
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderGrid.AutoGenerateColumns = false;
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderIdColumn,
            this.TimeColumn,
            this.UserColumn,
            this.priceColumn});
            this.orderGrid.DataSource = this.orderBindingSource;
            this.orderGrid.Location = new System.Drawing.Point(9, 3);
            this.orderGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.RowHeadersWidth = 51;
            this.orderGrid.RowTemplate.Height = 27;
            this.orderGrid.Size = new System.Drawing.Size(534, 611);
            this.orderGrid.TabIndex = 0;
            this.orderGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // OrderIdColumn
            // 
            this.OrderIdColumn.DataPropertyName = "OrderId";
            this.OrderIdColumn.HeaderText = "订单号";
            this.OrderIdColumn.MinimumWidth = 6;
            this.OrderIdColumn.Name = "OrderIdColumn";
            // 
            // TimeColumn
            // 
            this.TimeColumn.DataPropertyName = "CreateTime";
            this.TimeColumn.HeaderText = "下单时间";
            this.TimeColumn.MinimumWidth = 6;
            this.TimeColumn.Name = "TimeColumn";
            // 
            // UserColumn
            // 
            this.UserColumn.DataPropertyName = "CustomerName";
            this.UserColumn.HeaderText = "买家";
            this.UserColumn.MinimumWidth = 6;
            this.UserColumn.Name = "UserColumn";
            this.UserColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.DataPropertyName = "TotalPrice";
            this.priceColumn.HeaderText = "价格";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderApp.Order);
            // 
            // functionPanel
            // 
            this.functionPanel.AutoScroll = true;
            this.functionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.functionPanel.Controls.Add(this.btnAdd);
            this.functionPanel.Controls.Add(this.btnModify);
            this.functionPanel.Controls.Add(this.btnDelete);
            this.functionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.functionPanel.Location = new System.Drawing.Point(0, 37);
            this.functionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.functionPanel.Size = new System.Drawing.Size(1156, 37);
            this.functionPanel.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加订单";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(125, 4);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(100, 29);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "修改订单";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(233, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除订单";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // queryPanel
            // 
            this.queryPanel.AutoSize = true;
            this.queryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.queryPanel.Controls.Add(this.cbxField);
            this.queryPanel.Controls.Add(this.queryKeyword);
            this.queryPanel.Controls.Add(this.btnQuery);
            this.queryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.queryPanel.Location = new System.Drawing.Point(0, 0);
            this.queryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.queryPanel.Size = new System.Drawing.Size(1156, 37);
            this.queryPanel.TabIndex = 1;
            // 
            // cbxField
            // 
            this.cbxField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Items.AddRange(new object[] {
            "全部订单",
            "订单号",
            "买家名",
            "货物名",
            "价格"});
            this.cbxField.Location = new System.Drawing.Point(17, 7);
            this.cbxField.Margin = new System.Windows.Forms.Padding(4);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(113, 23);
            this.cbxField.TabIndex = 0;
            // 
            // queryKeyword
            // 
            this.queryKeyword.Location = new System.Drawing.Point(138, 4);
            this.queryKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.queryKeyword.Name = "queryKeyword";
            this.queryKeyword.Size = new System.Drawing.Size(249, 25);
            this.queryKeyword.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(395, 4);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 29);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询订单";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 704);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainApp";
            this.Text = "订单程序";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.functionPanel.ResumeLayout(false);
            this.queryPanel.ResumeLayout(false);
            this.queryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel queryPanel;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.TextBox queryKeyword;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.FlowLayoutPanel functionPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.DataGridView detailGrid;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectPriceColumn;
    }
}

