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
    public partial class EmployeesForm : Form
    {
        private EmployeeDB edb;
        private CategoryDB cdb;
        public EmployeesForm()
        {
            InitializeComponent();
            edb = (EmployeeDB)DbFactory.getDb("calisanlar");
            cdb = (CategoryDB)DbFactory.getDb("kategori");
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            loadCategories();
            cb_employeeCatS.SelectedIndex = -1;
            dgw.DataSource = edb.selectAll(edb.getTableName());
        }

        private void loadCategories()
        {
            cb_employeeCatS.DataSource = cdb.selectAll(cdb.getTableName());
            cb_employeeCatS.ValueMember = "id";
            cb_employeeCatS.DisplayMember = "name";
        }

        private void dgw_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_employeeID.Text = dgw.CurrentRow.Cells[0].Value.ToString();
            tb_employeeName.Text = dgw.CurrentRow.Cells[1].Value.ToString();
            tb_employeeSurname.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            tb_employeeCatID.Text = dgw.CurrentRow.Cells[3].Value.ToString();
            tb_employeeSalary.Text = dgw.CurrentRow.Cells[6].Value.ToString();

            dtp_doBirth.Text = dgw.CurrentRow.Cells[4].Value.ToString();
            dtp_doStart.Text = dgw.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            edb.updateEmployee(new employee(Convert.ToInt32(tb_employeeID.Text), tb_employeeName.Text, tb_employeeSurname.Text,
                Convert.ToInt32(tb_employeeCatID.Text), dtp_doBirth.Text, dtp_doStart.Text, float.Parse(tb_employeeSalary.Text)));
            dgw.DataSource = edb.selectAll(edb.getTableName());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            edb.deleteEmployee(Convert.ToInt32(tb_employeeID.Text));
            dgw.DataSource = edb.selectAll(edb.getTableName());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgw.DataSource = edb.selectAll(edb.getTableName());
        }

        private void btn_customerSID_Click(object sender, EventArgs e)
        {
            dgw.DataSource = edb.search(edb.getTableName(), "id", tb_employeeSID.Text);
        }

        private void btn_doBirthSearch_Click(object sender, EventArgs e)
        {
            dgw.DataSource = edb.searchStr(edb.getTableName(), "dogum_tarihi", dtp_doBirthSearch.Text);
            
        }

        private void btn_doStartSearch_Click(object sender, EventArgs e)
        {
            dgw.DataSource = edb.searchStr(edb.getTableName(), "ise_baslama", dtp_doStartSearch.Text);
        }

        private void btn_employeeBYS_Click(object sender, EventArgs e)
        {
            dgw.DataSource = edb.searchYear("dogum_tarihi", dtp_employeeBYS.Text);
        }

        private void btn_employeeBYMS_Click(object sender, EventArgs e)
        {
            dgw.DataSource = edb.searchYearMonth("dogum_tarihi", dtp_employeeBYMS.Text);
        }

        private void btn_employeeSYS_Click(object sender, EventArgs e)
        {
            dgw.DataSource = edb.searchYear("ise_baslama", dtp_employeeSYS.Text);
        }

        private void btn_employeeSYMS_Click(object sender, EventArgs e)
        {
            dgw.DataSource = edb.searchYearMonth("ise_baslama", dtp_employeeSYMS.Text);
        }

        private void tb_employeeNameS_TextChanged(object sender, EventArgs e)
        {
            dgw.DataSource = edb.wildSearch(edb.getTableName(), "ad", tb_employeeNameS.Text);
        }

        private void tb_employeeSurnameS_TextChanged(object sender, EventArgs e)
        {
            dgw.DataSource = edb.wildSearch(edb.getTableName(), "soyad", tb_employeeSurnameS.Text);
        }

        private void tb_employeeNameS_Click(object sender, EventArgs e)
        {
            tb_employeeSurnameS.Text = "";
        }

        private void tb_employeeSurnameS_Click(object sender, EventArgs e)
        {
            tb_employeeNameS.Text = "";
        }

        private void btn_employeeBMS_Click(object sender, EventArgs e)
        {
            int month = cb_employeeBMS.SelectedIndex + 1;
            dgw.DataSource = edb.searchMonth("dogum_tarihi", month.ToString());
        }

        private void btn_employeeSMS_Click(object sender, EventArgs e)
        {
            int month = cb_employeeSMS.SelectedIndex + 1;
            dgw.DataSource = edb.searchMonth("ise_baslama", month.ToString());
        }

        private void cb_employeeCatS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryId = Convert.ToInt32(cb_employeeCatS.SelectedIndex) + 1;
            dgw.DataSource = edb.search(edb.getTableName(), "kategori_id", selectedCategoryId.ToString());
        }

        private void btn_addEmp_Click(object sender, EventArgs e)
        {
            new NewEmployeeForm(btn_addEmp, dgw).Show();
            btn_addEmp.Enabled = false;
        }
    }
}
