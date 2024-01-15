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
    public partial class SalesForm : Form
    {
        private SalesDB sdb;
        public SalesForm()
        {
            InitializeComponent();
            sdb = (SalesDB)DbFactory.getDb("satis");
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            dgw_sales.DataSource = sdb.selectAll(sdb.getTableName());
            cb_MonthsSearch.SelectedIndex = 0;
        }

        private void dgw_sales_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgw_saleDetails.DataSource = sdb.getSaleDetails(SaleBuilder.startBuild().setid(Convert.ToInt32(dgw_sales.CurrentRow.Cells[0].Value)).build());
        }

        private void btn_searchYorM_Click(object sender, EventArgs e)
        {
            if(cb_MonthsSearch.SelectedIndex == 0)
            {
                dgw_sales.DataSource = sdb.searchYear("tarih", dtp_YearSearch.Text);
                
            }
            else
            {
                string dateValue = dtp_YearSearch.Text + "-" + cb_MonthsSearch.SelectedIndex.ToString();
                dgw_sales.DataSource = sdb.searchYearMonth("tarih", dateValue);
            }

            statisticsHeaderLbl.Text = dtp_YearSearch.Text + " " + cb_MonthsSearch.SelectedItem.ToString();
            salesCountLbl.Text = dgw_sales.Rows.Count.ToString();

            float totalSales = 0;
            foreach(DataGridViewRow row in dgw_sales.Rows)
            {
                totalSales += float.Parse(row.Cells[3].Value.ToString());
            }

            salesTotalLbl.Text = totalSales.ToString() + " TL"; ;
            salesAvgLbl.Text = (totalSales / Convert.ToInt32(salesCountLbl.Text)).ToString() + " TL"; ;
        }

        private void btn_searchSaleID_Click(object sender, EventArgs e)
        {
            dgw_sales.DataSource = sdb.search(sdb.getTableName(), "id", tb_saleIDS.Text);
        }

        private void btn_searchCustomerID_Click(object sender, EventArgs e)
        {
            dgw_sales.DataSource = sdb.search(sdb.getTableName(), "musteri_id", tb_customerIDS.Text);
        }

        private void btn_searchDate_Click(object sender, EventArgs e)
        {
            dgw_sales.DataSource = sdb.searchStr(sdb.getTableName(), "tarih", dtp_dateSearch.Text);

            string[] date = dtp_dateSearch.Value.ToString("yyyy.dd.MMMM").Split('.');
            statisticsHeaderLbl.Text = date[0] + " " + date[1] + " " + date[2];
            salesCountLbl.Text = dgw_sales.Rows.Count.ToString();

            float totalSales = 0;
            foreach (DataGridViewRow row in dgw_sales.Rows)
            {
                totalSales += float.Parse(row.Cells[3].Value.ToString());
            }

            salesTotalLbl.Text = totalSales.ToString() + " TL";
            salesAvgLbl.Text = (totalSales / Convert.ToInt32(salesCountLbl.Text)).ToString() + " TL";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgw_sales.DataSource = sdb.selectAll(sdb.getTableName());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
