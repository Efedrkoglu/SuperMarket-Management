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
    public partial class NewSupplierForm : Form
    {
        private SupplierDB sdb;
        private Button btn;
        private DataGridView dgw;
        public NewSupplierForm(Button btn, DataGridView dgw)
        {
            InitializeComponent();
            this.btn = btn;
            this.dgw = dgw;
            sdb = (SupplierDB)DbFactory.getDb("tedarikci");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            sdb.insertSupplier(new supplier(Convert.ToInt32(tb_supplierID.Text), tb_supplierName.Text, tb_supplierTel.Text, tb_supplierAdd.Text));
            dgw.DataSource = sdb.selectAll(sdb.getTableName());
            btn.Enabled = true;
            this.Close();
        }

        private void NewSupplierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgw.DataSource = sdb.selectAll(sdb.getTableName());
            btn.Enabled = true;
        }
    }
}
