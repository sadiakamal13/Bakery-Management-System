using System;
using System.Windows.Forms;

namespace BakeryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            // Validate customer name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please Enter Customer Name!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Create customer and bakery objects
            Customer customer = new Customer(txtName.Text.Trim());
            Bakery bakery = new Bakery();

            // Open Order Form
            OrderForm orderForm = new OrderForm(customer, bakery);
            orderForm.Show();
            this.Hide();
        }
    }
}