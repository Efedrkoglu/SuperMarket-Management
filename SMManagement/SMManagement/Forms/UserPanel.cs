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
    public partial class UserPanel : Form
    {
        private Form login;
        public UserPanel(Form login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            new GetCustomerIdForm().Show();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            new ProductsUser().Show();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            new CustomersUserForm().Show();
        }
    }
}
