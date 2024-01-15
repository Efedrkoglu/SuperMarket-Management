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
    public partial class NewEmployeeForm : Form
    {
        private Button btn;
        private DataGridView dgw;
        private EmployeeDB edb;
        public NewEmployeeForm(Button btn, DataGridView dgw)
        {
            InitializeComponent();
            this.btn = btn;
            this.dgw = dgw;
            edb = (EmployeeDB)DbFactory.getDb("calisanlar");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            edb.insertEmployee(new employee(Convert.ToInt32(tb_employeeID.Text), tb_employeeName.Text, tb_employeeSurname.Text,
                Convert.ToInt32(tb_employeeCatID.Text), dtp_doBirth.Text, dtp_doStart.Text, float.Parse(tb_employeeSalary.Text)));
            dgw.DataSource = edb.selectAll(edb.getTableName());
            btn.Enabled = true;
            this.Close();
        }

        private void NewEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn.Enabled = true;
        }
    }
}
