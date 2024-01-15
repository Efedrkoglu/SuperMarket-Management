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
    public partial class NewCustomerForm : Form
    {
        private Button btn;
        private DataGridView dgw;
        private CustomerDB cdb;

        public NewCustomerForm(Button btn, DataGridView dgw)
        {
            InitializeComponent();
            cdb = (CustomerDB)DbFactory.getDb("musteri");
            this.btn = btn;
            this.dgw = dgw;
        }

        private void NewCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cdb.insertCustomer(new customer(Convert.ToInt32(tb_customerID.Text), tb_customerName.Text, tb_customerSurname.Text, tb_customerPhone.Text));
            dgw.DataSource = cdb.selectAll(cdb.getTableName());
            btn.Enabled = true;
            this.Close();
        }
    }
}
