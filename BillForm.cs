using System;
using System.Windows.Forms;

namespace BakeryManagementSystem
{
    public partial class BillForm : Form
    {
        private Customer customer;
        private Bakery bakery;

        public BillForm(Customer customer, Bakery bakery)
        {
            InitializeComponent();
            this.customer = customer;
            this.bakery = bakery;

            LoadBill();
        }

        private void LoadBill()
        {
            lblCustomerName.Text = "Customer Name : " + customer.Name;
            lblDate.Text = "Date : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            lvBill.Items.Clear();

            foreach (OrderItem item in bakery.Orders)
            {
                ListViewItem row = new ListViewItem(item.ItemName);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add("Rs. " + item.Price);
                row.SubItems.Add("Rs. " + item.TotalPrice());
                lvBill.Items.Add(row);
            }

            lblGrandTotal.Text = "GRAND TOTAL:  Rs. " + bakery.CalculateGrandTotal();
        }

        // 🖨 Print Button
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string billText = "===== BAKERY MANAGEMENT SYSTEM =====\n";
            billText += "           FINAL BILL\n\n";
            billText += "Customer: " + customer.Name + "\n";
            billText += "Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n";
            billText += "-----------------------------------\n";

            foreach (OrderItem item in bakery.Orders)
            {
                billText += item.ItemName + " x " + item.Quantity +
                            " = Rs. " + item.TotalPrice() + "\n";
            }

            billText += "-----------------------------------\n";
            billText += "GRAND TOTAL: Rs. " + bakery.CalculateGrandTotal() + "\n";
            billText += "\nThank you for your purchase! 🍰";

            MessageBox.Show(billText, "Bill Preview",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 🔄 New Customer Button
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}