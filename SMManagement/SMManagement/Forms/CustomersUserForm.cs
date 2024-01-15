using SMManagement.Script;
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
    public partial class CustomersUserForm : Form
    {
        private CustomerDB cdb;
        public CustomersUserForm()
        {
            InitializeComponent();
            cdb = (CustomerDB)DbFactory.getDb("musteri");
        }

        private void CustomersUserForm_Load(object sender, EventArgs e)
        {
            dgw.DataSource = cdb.selectAll(cdb.getTableName());
        }

        private void btn_customerSID_Click(object sender, EventArgs e)
        {
            dgw.DataSource = cdb.search(cdb.getTableName(), "id", tb_customerIDS.Text);
        }

        private void tb_customerNameS_TextChanged(object sender, EventArgs e)
        {
            dgw.DataSource = cdb.wildSearch(cdb.getTableName(), "ad", tb_customerNameS.Text);
        }

        private void tb_customerNameS_Click(object sender, EventArgs e)
        {
            tb_customerSurnameS.Text = "";
        }

        private void tb_customerSurnameS_TextChanged(object sender, EventArgs e)
        {
            dgw.DataSource = cdb.wildSearch(cdb.getTableName(), "soyad", tb_customerSurnameS.Text);
        }

        private void tb_customerSurnameS_Click(object sender, EventArgs e)
        {
            tb_customerNameS.Text = "";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgw.DataSource = cdb.selectAll(cdb.getTableName());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newCustomer_Click(object sender, EventArgs e)
        {
            new NewCustomerForm(btn_newCustomer, dgw).Show();
            btn_newCustomer.Enabled = false;
        }

        
    }
}
