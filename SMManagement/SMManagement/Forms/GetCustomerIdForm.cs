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
    public partial class GetCustomerIdForm : Form
    {
        private SalesDB sdb;

        public GetCustomerIdForm()
        {
            InitializeComponent();
            this.sdb = (SalesDB)DbFactory.getDb("satis");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today; ;
            if(!tb_customerId.Text.Equals(""))
            {
                sdb.insertSale(SaleBuilder.startBuild().setCustomerId(Convert.ToInt32(tb_customerId.Text)).setDate(date.ToString("yyyy-MM-dd")).setTotal(0).build()); 
            }
            else
            {
                sdb.insertSaleNullCustomer(SaleBuilder.startBuild().setDate(date.ToString("yyyy-MM-dd")).setTotal(0).build());
            }
            
            new SaleDetailForm().Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
