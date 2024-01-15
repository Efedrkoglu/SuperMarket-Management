using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMManagement.Script;

namespace SMManagement.Forms
{
    public partial class NewProduct : Form
    {
        private Products productPanel;
        private ProductDB pdb;
        public NewProduct(Products productPanel)
        {
            InitializeComponent();
            this.productPanel = productPanel;
            pdb = (ProductDB)DbFactory.getDb("urunler");
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            cb_priceType.Items.Add("birim");
            cb_priceType.Items.Add("kg");
        }

        private void NewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            productPanel.btn_newProduct.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pdb.insertProduct(new product(Convert.ToInt32(tb_productID.Text), tb_productName.Text, cb_priceType.SelectedItem.ToString(), float.Parse(tb_price.Text), chb_stok.Checked, Convert.ToInt32(tb_category.Text), Convert.ToInt32(tb_supplier.Text)));
                productPanel.dataGridView1.DataSource = pdb.selectAll(pdb.getTableName());
                productPanel.btn_newProduct.Enabled = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
