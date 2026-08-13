namespace BakeryManagementSystem
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.rbCookies = new System.Windows.Forms.RadioButton();
            this.rbBread = new System.Windows.Forms.RadioButton();
            this.rbCake = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblItemTotal = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRunningTotal = new System.Windows.Forms.Label();
            this.grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19)))));
            this.lblTitle.Location = new System.Drawing.Point(26, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(694, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🛒 PLACE YOUR ORDER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(51)))), ((int)(((byte)(23)))));
            this.lblCustomer.Location = new System.Drawing.Point(32, 80);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(514, 29);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer: ";
            // 
            // grpItems
            // 
            this.grpItems.BackColor = System.Drawing.Color.Transparent;
            this.grpItems.Controls.Add(this.rbCookies);
            this.grpItems.Controls.Add(this.rbBread);
            this.grpItems.Controls.Add(this.rbCake);
            this.grpItems.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.grpItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(51)))), ((int)(((byte)(23)))));
            this.grpItems.Location = new System.Drawing.Point(32, 127);
            this.grpItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpItems.Name = "grpItems";
            this.grpItems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpItems.Size = new System.Drawing.Size(694, 160);
            this.grpItems.TabIndex = 2;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Select Item";
            // 
            // rbCookies
            // 
            this.rbCookies.Font = new System.Drawing.Font("Arial", 11F);
            this.rbCookies.Location = new System.Drawing.Point(26, 113);
            this.rbCookies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCookies.Name = "rbCookies";
            this.rbCookies.Size = new System.Drawing.Size(321, 33);
            this.rbCookies.TabIndex = 2;
            this.rbCookies.Text = "🍪 Cookies   - Rs. 200";
            this.rbCookies.UseVisualStyleBackColor = true;
            // 
            // rbBread
            // 
            this.rbBread.Font = new System.Drawing.Font("Arial", 11F);
            this.rbBread.Location = new System.Drawing.Point(26, 73);
            this.rbBread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBread.Name = "rbBread";
            this.rbBread.Size = new System.Drawing.Size(321, 33);
            this.rbBread.TabIndex = 1;
            this.rbBread.Text = "🍞 Bread     - Rs. 100";
            this.rbBread.UseVisualStyleBackColor = true;
            // 
            // rbCake
            // 
            this.rbCake.Font = new System.Drawing.Font("Arial", 11F);
            this.rbCake.Location = new System.Drawing.Point(26, 33);
            this.rbCake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCake.Name = "rbCake";
            this.rbCake.Size = new System.Drawing.Size(321, 33);
            this.rbCake.TabIndex = 0;
            this.rbCake.Text = "🎂 Cake      - Rs. 500";
            this.rbCake.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(51)))), ((int)(((byte)(23)))));
            this.lblQuantity.Location = new System.Drawing.Point(32, 307);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(103, 33);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nudQuantity.Font = new System.Drawing.Font("Arial", 12F);
            this.nudQuantity.Location = new System.Drawing.Point(141, 304);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(103, 35);
            this.nudQuantity.TabIndex = 4;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblItemTotal
            // 
            this.lblItemTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblItemTotal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblItemTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.lblItemTotal.Location = new System.Drawing.Point(283, 307);
            this.lblItemTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemTotal.Name = "lblItemTotal";
            this.lblItemTotal.Size = new System.Drawing.Size(321, 33);
            this.lblItemTotal.TabIndex = 5;
            this.lblItemTotal.Text = "Item Total: Rs. 0";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(32, 367);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(193, 51);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "ADD TO ORDER";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBill.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewBill.ForeColor = System.Drawing.Color.White;
            this.btnViewBill.Location = new System.Drawing.Point(251, 367);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(193, 51);
            this.btnViewBill.TabIndex = 7;
            this.btnViewBill.Text = "VIEW BILL";
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // lvOrders
            // 
            this.lvOrders.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItem,
            this.colQty,
            this.colPrice,
            this.colTotal});
            this.lvOrders.Font = new System.Drawing.Font("Arial", 10F);
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.GridLines = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(32, 440);
            this.lvOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(693, 172);
            this.lvOrders.TabIndex = 8;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            // 
            // colItem
            // 
            this.colItem.Text = "Item";
            this.colItem.Width = 180;
            // 
            // colQty
            // 
            this.colQty.Text = "Qty";
            this.colQty.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 130;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            this.colTotal.Width = 130;
            // 
            // lblRunningTotal
            // 
            this.lblRunningTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblRunningTotal.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblRunningTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19)))));
            this.lblRunningTotal.Location = new System.Drawing.Point(32, 633);
            this.lblRunningTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRunningTotal.Name = "lblRunningTotal";
            this.lblRunningTotal.Size = new System.Drawing.Size(694, 40);
            this.lblRunningTotal.TabIndex = 9;
            this.lblRunningTotal.Text = "Total: Rs. 0";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 693);
            this.Controls.Add(this.lblRunningTotal);
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblItemTotal);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Your Order";
            this.grpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.RadioButton rbCookies;
        private System.Windows.Forms.RadioButton rbBread;
        private System.Windows.Forms.RadioButton rbCake;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblItemTotal;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.Label lblRunningTotal;
    }
}