namespace assignment6
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.userId = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.detailsGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.AddGoodBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemNumLabel = new System.Windows.Forms.Label();
            this.ItemPrice = new System.Windows.Forms.Label();
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.GoodId = new System.Windows.Forms.TextBox();
            this.GoodName = new System.Windows.Forms.TextBox();
            this.goodNum = new System.Windows.Forms.TextBox();
            this.goodPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IdLabel = new System.Windows.Forms.Label();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.detailsGrid);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 580);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.userId);
            this.panel5.Controls.Add(this.userIDBox);
            this.panel5.Location = new System.Drawing.Point(611, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 42);
            this.panel5.TabIndex = 7;
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Location = new System.Drawing.Point(3, 16);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(68, 15);
            this.userId.TabIndex = 1;
            this.userId.Text = "用户Id：";
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(76, 6);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(165, 25);
            this.userIDBox.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.userName);
            this.panel4.Controls.Add(this.userNameBox);
            this.panel4.Location = new System.Drawing.Point(322, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 42);
            this.panel4.TabIndex = 6;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(3, 16);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 15);
            this.userName.TabIndex = 1;
            this.userName.Text = "用户名：";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(76, 6);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(165, 25);
            this.userNameBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addBtn.Location = new System.Drawing.Point(698, 235);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(116, 45);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "添加订单";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // detailsGrid
            // 
            this.detailsGrid.AllowUserToAddRows = false;
            this.detailsGrid.AutoGenerateColumns = false;
            this.detailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.detailsGrid.DataSource = this.orderDetailBindingSource;
            this.detailsGrid.Location = new System.Drawing.Point(34, 300);
            this.detailsGrid.Name = "detailsGrid";
            this.detailsGrid.RowHeadersWidth = 51;
            this.detailsGrid.RowTemplate.Height = 27;
            this.detailsGrid.Size = new System.Drawing.Size(900, 279);
            this.detailsGrid.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.deleteBtn);
            this.panel3.Controls.Add(this.AddGoodBtn);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(42, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 195);
            this.panel3.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(304, 168);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 24);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "删除商品";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AddGoodBtn
            // 
            this.AddGoodBtn.Location = new System.Drawing.Point(6, 171);
            this.AddGoodBtn.Name = "AddGoodBtn";
            this.AddGoodBtn.Size = new System.Drawing.Size(105, 24);
            this.AddGoodBtn.TabIndex = 6;
            this.AddGoodBtn.Text = "添加商品";
            this.AddGoodBtn.UseVisualStyleBackColor = true;
            this.AddGoodBtn.Click += new System.EventHandler(this.AddGoodBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.39663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.60337F));
            this.tableLayoutPanel1.Controls.Add(this.ItemNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ItemNumLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ItemPrice, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ItemIdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GoodId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GoodName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.goodNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.goodPrice, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 130);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(3, 31);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(67, 15);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "商品名称";
            // 
            // ItemNumLabel
            // 
            this.ItemNumLabel.AutoSize = true;
            this.ItemNumLabel.Location = new System.Drawing.Point(3, 66);
            this.ItemNumLabel.Name = "ItemNumLabel";
            this.ItemNumLabel.Size = new System.Drawing.Size(67, 15);
            this.ItemNumLabel.TabIndex = 2;
            this.ItemNumLabel.Text = "商品数量";
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSize = true;
            this.ItemPrice.Location = new System.Drawing.Point(3, 100);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(67, 15);
            this.ItemPrice.TabIndex = 4;
            this.ItemPrice.Text = "商品价格";
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(52, 15);
            this.ItemIdLabel.TabIndex = 3;
            this.ItemIdLabel.Text = "商品号";
            // 
            // GoodId
            // 
            this.GoodId.Location = new System.Drawing.Point(150, 3);
            this.GoodId.Name = "GoodId";
            this.GoodId.Size = new System.Drawing.Size(232, 25);
            this.GoodId.TabIndex = 5;
            // 
            // GoodName
            // 
            this.GoodName.Location = new System.Drawing.Point(150, 34);
            this.GoodName.Name = "GoodName";
            this.GoodName.Size = new System.Drawing.Size(232, 25);
            this.GoodName.TabIndex = 6;
            // 
            // goodNum
            // 
            this.goodNum.Location = new System.Drawing.Point(150, 69);
            this.goodNum.Name = "goodNum";
            this.goodNum.Size = new System.Drawing.Size(232, 25);
            this.goodNum.TabIndex = 7;
            // 
            // goodPrice
            // 
            this.goodPrice.Location = new System.Drawing.Point(150, 103);
            this.goodPrice.Name = "goodPrice";
            this.goodPrice.Size = new System.Drawing.Size(232, 25);
            this.goodPrice.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IdLabel);
            this.panel2.Controls.Add(this.OrderId);
            this.panel2.Location = new System.Drawing.Point(42, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 42);
            this.panel2.TabIndex = 2;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 16);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(67, 15);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "订单号：";
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(76, 6);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(165, 25);
            this.OrderId.TabIndex = 0;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "序号";
            this.indexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.goodsNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "商品单价";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(OrderApp.OrderDetail);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 591);
            this.Controls.Add(this.panel1);
            this.Name = "AddForm";
            this.Text = "添加订单";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.Label ItemNumLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ItemPrice;
        private System.Windows.Forms.Button AddGoodBtn;
        private System.Windows.Forms.TextBox GoodId;
        private System.Windows.Forms.TextBox GoodName;
        private System.Windows.Forms.TextBox goodNum;
        private System.Windows.Forms.TextBox goodPrice;
        private System.Windows.Forms.DataGridView detailsGrid;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label userId;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox userNameBox;
    }
}