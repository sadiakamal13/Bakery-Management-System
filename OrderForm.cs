using System;
using System.Windows.Forms;

namespace BakeryManagementSystem
{
    public partial class OrderForm : Form
    {
        private Customer customer;
        private Bakery bakery;

        public OrderForm(Customer customer, Bakery bakery)
        {
            InitializeComponent();
            this.customer = customer;
            this.bakery = bakery;

            // Display customer name
            lblCustomer.Text = "Customer: " + customer.Name;

            // Default selection
            rbCake.Checked = true;

            // Attach live update events
            nudQuantity.ValueChanged += UpdateItemTotal;
            rbCake.CheckedChanged += UpdateItemTotal;
            rbBread.CheckedChanged += UpdateItemTotal;
            rbCookies.CheckedChanged += UpdateItemTotal;

            UpdateItemTotal(null, null);
        }

        // Get price based on selected radio button
        private int GetSelectedPrice()
        {
            if (rbCake.Checked) return 500;
            if (rbBread.Checked) return 100;
            if (rbCookies.Checked) return 200;
            return 0;
        }

        // Get item name based on selected radio button
        private string GetSelectedName()
        {
            if (rbCake.Checked) return "Cake";
            if (rbBread.Checked) return "Bread";
            if (rbCookies.Checked) return "Cookies";
            return "";
        }

        // Live update item total label
        private void UpdateItemTotal(object sender, EventArgs e)
        {
            int total = GetSelectedPrice() * (int)nudQuantity.Value;
            lblItemTotal.Text = "Item Total: Rs. " + total;
        }

        // Add Order button click
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Validate selection
            if (!rbCake.Checked && !rbBread.Checked && !rbCookies.Checked)
            {
                MessageBox.Show("Please Select an Item!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create order item
            OrderItem item = new OrderItem
            {
                ItemName = GetSelectedName(),
                Price = GetSelectedPrice(),
                Quantity = (int)nudQuantity.Value
            };

            // Add to bakery list
            bakery.AddOrder(item);

            // Add to ListView display
            ListViewItem row = new ListViewItem(item.ItemName);
            row.SubItems.Add(item.Quantity.ToString());
            row.SubItems.Add("Rs. " + item.Price);
            row.SubItems.Add("Rs. " + item.TotalPrice());
            lvOrders.Items.Add(row);

            // Update running total
            lblRunningTotal.Text = "Running Total: Rs. " + bakery.CalculateGrandTotal();

            // Success message
            MessageBox.Show(item.ItemName + " x " + item.Quantity + " added!",
                "Item Added",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset quantity
            nudQuantity.Value = 1;
        }

        // View Bill button click
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            // Check if any orders exist
            if (bakery.Orders.Count == 0)
            {
                MessageBox.Show("No Orders Added Yet!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open Bill Form
            BillForm billForm = new BillForm(customer, bakery);
            billForm.Show();
            this.Hide();
        }

        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {

        }

        private void btnViewBill_Click_1(object sender, EventArgs e)
        {

        }
    }
}