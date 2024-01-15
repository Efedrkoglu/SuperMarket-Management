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
    public partial class Products : Form
    {  
        private ProductDB pdb;
        private CategoryDB cdb;
        public Products()
        {
            InitializeComponent();
            pdb = (ProductDB)DbFactory.getDb("urunler");
            cdb = (CategoryDB)DbFactory.getDb("kategori");
        }

        private void Products_Load(object sender, EventArgs e)
        {
            cb_priceType.Items.Add("birim");
            cb_priceType.Items.Add("kg");
            loadCategories();
            cb_categories.SelectedIndex = -1;
            dataGridView1.DataSource = pdb.selectAll(pdb.getTableName());
        }

        private void loadCategories()
        {
            cb_categories.DataSource = cdb.selectAll(cdb.getTableName());
            cb_categories.ValueMember = "id";
            cb_categories.DisplayMember = "name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NewProduct(this).Show();
            btn_newProduct.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_productID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_productName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_priceType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            chb_stok.Checked = bool.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            tb_category.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_supplier.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            pdb.updateProduct(new product(Convert.ToInt32(tb_productID.Text), tb_productName.Text, cb_priceType.SelectedItem.ToString(), float.Parse(tb_price.Text), chb_stok.Checked, Convert.ToInt32(tb_category.Text), Convert.ToInt32(tb_supplier.Text)));
            dataGridView1.DataSource = pdb.selectAll(pdb.getTableName());
        }

        private void tb_productNameS_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pdb.wildSearch(pdb.getTableName(), "isim", tb_productNameS.Text);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pdb.selectAll(pdb.getTableName());
        }

        private void btn_searchPID_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pdb.search(pdb.getTableName(), "id", tb_productIDS.Text);
        }

        private void btn_searchSID_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pdb.search(pdb.getTableName(), "tedarikci_id", tb_supplierIDS.Text);
        }

        private void cb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryId = Convert.ToInt32(cb_categories.SelectedIndex) + 1; 
            dataGridView1.DataSource = pdb.search(pdb.getTableName(), "kategori_id", selectedCategoryId.ToString());
        }

        
    }
}
