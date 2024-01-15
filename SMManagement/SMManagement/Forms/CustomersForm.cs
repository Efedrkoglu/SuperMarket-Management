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
    public partial class CustomersForm : Form
    {
        private CustomerDB cdb;
        public CustomersForm()
        {
            InitializeComponent();
            cdb = (CustomerDB)DbFactory.getDb("musteri");
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            dgw.DataSource = cdb.selectAll(cdb.getTableName());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgw_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_customerID.Text = dgw.CurrentRow.Cells[0].Value.ToString();
            tb_customerName.Text = dgw.CurrentRow.Cells[1].Value.ToString();
            tb_customerSurname.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            tb_customerPhone.Text = dgw.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cdb.updateCustomer(new customer(Convert.ToInt32(tb_customerID.Text), tb_customerName.Text, tb_customerSurname.Text, tb_customerPhone.Text));
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

        private void btn_newCustomer_Click(object sender, EventArgs e)
        {
            new NewCustomerForm(btn_newCustomer, dgw).Show();
            btn_newCustomer.Enabled = false;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgw.DataSource = cdb.selectAll(cdb.getTableName());
        }
    }
}
