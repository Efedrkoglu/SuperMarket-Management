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
    public partial class SuppliersForm : Form
    {
        private SupplierDB sdb;
        public SuppliersForm()
        {
            InitializeComponent();
            sdb = (SupplierDB)DbFactory.getDb("tedarikci");
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            dgw.DataSource = sdb.selectAll(sdb.getTableName());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgw_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_supplierID.Text = dgw.CurrentRow.Cells[0].Value.ToString();
            tb_supplierName.Text = dgw.CurrentRow.Cells[1].Value.ToString();
            tb_supplierTel.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            tb_supplierAdd.Text = dgw.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sdb.updateSupplier(new supplier(Convert.ToInt32(tb_supplierID.Text), tb_supplierName.Text, tb_supplierTel.Text, tb_supplierAdd.Text));
            dgw.DataSource = sdb.selectAll(sdb.getTableName());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgw.DataSource = sdb.selectAll(sdb.getTableName());
        }

        private void btn_searchID_Click(object sender, EventArgs e)
        {
            dgw.DataSource = sdb.search(sdb.getTableName(), "id", tb_supplierSID.Text);
        }

        private void tb_supplierSName_TextChanged(object sender, EventArgs e)
        {
            dgw.DataSource = sdb.wildSearch(sdb.getTableName(), "isim", tb_supplierSName.Text);
        }

        private void tb_supplierSAdd_TextChanged(object sender, EventArgs e)
        {
            dgw.DataSource = sdb.wildSearch(sdb.getTableName(), "address", tb_supplierSAdd.Text);
        }

        private void tb_supplierSName_Click(object sender, EventArgs e)
        {
            tb_supplierSAdd.Text = "";
        }

        private void tb_supplierSAdd_Click(object sender, EventArgs e)
        {
            tb_supplierSName.Text = "";
        }

        private void btn_newSupplier_Click(object sender, EventArgs e)
        {
            new NewSupplierForm(btn_newSupplier, dgw).Show();
            btn_newSupplier.Enabled = false;
        }
    }
}
