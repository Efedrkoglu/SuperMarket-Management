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
using System.Xml.Schema;

namespace SMManagement.Forms
{
    public partial class SaleDetailForm : Form
    {
        private int saleId;
        private SalesDB sdb;
        public SaleDetailForm()
        {
            InitializeComponent();
            this.sdb = (SalesDB)DbFactory.getDb("satis");
        }

        private void SaleDetailForm_Load(object sender, EventArgs e)
        {
            DataTable dt = sdb.getMaxId();
            DataView dv = new DataView(dt);

            if (dv.Count > 0)
                saleId = (int)dv[0]["max"];

            saleIdLbl.Text = saleId.ToString();

            dgw.DataSource = sdb.getSaleDetails(SaleBuilder.startBuild().setid(saleId).build());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            sdb.insertSaleDetail(new saleDetail(saleId, Convert.ToInt32(tb_productId.Text), float.Parse(tb_amount.Text)));
            dgw.DataSource = sdb.getSaleDetails(SaleBuilder.startBuild().setid(saleId).build());
        }

        private void dgw_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_productIdU.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            tb_amountU.Text = dgw.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sdb.updateSaleDetail(new saleDetail(Convert.ToInt32(dgw.CurrentRow.Cells[0].Value), saleId, Convert.ToInt32(tb_productIdU.Text), float.Parse(tb_amountU.Text)));
            dgw.DataSource = sdb.getSaleDetails(SaleBuilder.startBuild().setid(saleId).build());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sdb.deleteSaleDetail(Convert.ToInt32(dgw.CurrentRow.Cells[0].Value));
            dgw.DataSource = sdb.getSaleDetails(SaleBuilder.startBuild().setid(saleId).build());
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            sdb.completeSale(SaleBuilder.startBuild().setid(saleId).build());
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            sdb.cancelSale(SaleBuilder.startBuild().setid(saleId).build());
            this.Close();
        }
    }
}
