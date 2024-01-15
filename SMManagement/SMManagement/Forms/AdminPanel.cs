using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMManagement.Forms
{
    public partial class AdminPanel : Form
    {
        private Login loginPanel;
        public AdminPanel(Login loginPanel)
        {
            InitializeComponent();
            this.loginPanel = loginPanel;
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginPanel.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            this.Close();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            new Products().Show();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            new CategoriesForm().Show();
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            new SuppliersForm().Show();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            new EmployeesForm().Show();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            new CustomersForm().Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            new SalesForm().Show();
        }
    }
}
