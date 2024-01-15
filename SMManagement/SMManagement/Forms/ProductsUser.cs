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
    public partial class ProductsUser : Form
    {
        private ProductDB pdb;
        private CategoryDB cdb;
        public ProductsUser()
        {
            InitializeComponent();
            pdb = (ProductDB)DbFactory.getDb("urunler");
            cdb = (CategoryDB)DbFactory.getDb("kategori");
        }

        private void ProductsUser_Load(object sender, EventArgs e)
        {
            loadCategories();
            cb_categories.SelectedIndex = -1;
            dgw.DataSource = pdb.selectAll(pdb.getTableName());
        }

        private void loadCategories()
        {
            cb_categories.DataSource = cdb.selectAll(cdb.getTableName());
            cb_categories.ValueMember = "id";
            cb_categories.DisplayMember = "name";
        }

        private void btn_searchPID_Click(object sender, EventArgs e)
        {
            dgw.DataSource = pdb.search(pdb.getTableName(), "id", tb_productIDS.Text);
        }

        private void btn_searchSID_Click(object sender, EventArgs e)
        {
            dgw.DataSource = pdb.search(pdb.getTableName(), "tedarikci_id", tb_supplierIDS.Text);
        }

        private void tb_productNameS_TextChanged(object sender, EventArgs e)
        {
            dgw.DataSource = pdb.wildSearch(pdb.getTableName(), "isim", tb_productNameS.Text);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryId = Convert.ToInt32(cb_categories.SelectedIndex) + 1;
            dgw.DataSource = pdb.search(pdb.getTableName(), "kategori_id", selectedCategoryId.ToString());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgw.DataSource = pdb.selectAll(pdb.getTableName());
        }
    }
}
