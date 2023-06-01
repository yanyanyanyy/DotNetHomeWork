namespace assignment6
{
    partial class changeForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.userId = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.detailsGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemNumLabel = new System.Windows.Forms.Label();
            this.ItemPrice = new System.Windows.Forms.Label();
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.GoodId = new System.Windows.Forms.TextBox();
            this.GoodName = new System.Windows.Forms.TextBox();
            this.goodNum = new System.Windows.Forms.TextBox();
            this.goodPrice = new System.Windows.Forms.TextBox();
            this.changeGoodBtn = new System.Windows.Forms.Button();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.userId);
            this.panel5.Controls.Add(this.userIDBox);
            this.panel5.Location = new System.Drawing.Point(421, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 42);
            this.panel5.TabIndex = 13;
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
            this.panel4.Location = new System.Drawing.Point(125, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 42);
            this.panel4.TabIndex = 12;
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
            this.addBtn.Location = new System.Drawing.Point(901, 290);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(116, 45);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "修改订单";
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
            this.detailsGrid.Location = new System.Drawing.Point(117, 344);
            this.detailsGrid.Name = "detailsGrid";
            this.detailsGrid.RowHeadersWidth = 51;
            this.detailsGrid.RowTemplate.Height = 27;
            this.detailsGrid.Size = new System.Drawing.Size(900, 279);
            this.detailsGrid.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.changeGoodBtn);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(125, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 195);
            this.panel3.TabIndex = 9;
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
            // changeGoodBtn
            // 
            this.changeGoodBtn.Location = new System.Drawing.Point(6, 171);
            this.changeGoodBtn.Name = "changeGoodBtn";
            this.changeGoodBtn.Size = new System.Drawing.Size(105, 24);
            this.changeGoodBtn.TabIndex = 6;
            this.changeGoodBtn.Text = "修改商品";
            this.changeGoodBtn.UseVisualStyleBackColor = true;
            this.changeGoodBtn.Click += new System.EventHandler(this.changeGoodBtn_Click);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(OrderApp.OrderDetail);
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "序列号";
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
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
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
            // changeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 692);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.detailsGrid);
            this.Controls.Add(this.panel3);
            this.Name = "changeForm";
            this.Text = "changeForm";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label userId;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView detailsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button changeGoodBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemNumLabel;
        private System.Windows.Forms.Label ItemPrice;
        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.TextBox GoodId;
        private System.Windows.Forms.TextBox GoodName;
        private System.Windows.Forms.TextBox goodNum;
        private System.Windows.Forms.TextBox goodPrice;
    }
}