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
    public partial class CategoriesForm : Form
    {
        private CategoryDB cdb;
        public CategoriesForm()
        {
            InitializeComponent();
            cdb = (CategoryDB)DbFactory.getDb("kategori");
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            dgw.DataSource = cdb.selectAll(cdb.getTableName());
        }

        private void dgw_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_categoryID.Text = dgw.CurrentRow.Cells[0].Value.ToString();
            tb_categoryName.Text = dgw.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cdb.updateCategory(new category(Convert.ToInt32(tb_categoryID.Text), tb_categoryName.Text));
            dgw.DataSource = cdb.selectAll(cdb.getTableName());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cdb.insertCategory(new category(Convert.ToInt32(tb_newCatID.Text), tb_newCatName.Text));
            dgw.DataSource = cdb.selectAll(cdb.getTableName());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
