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
    public partial class directLoginForm : Form
    {
        public directLoginForm()
        {
            InitializeComponent();
        }

        private void btn_userLogin_Click(object sender, EventArgs e)
        {
            new UserPanel(this).Show();
            this.Hide();
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            new AdminPanel(this).Show();
            this.Hide();
        }
    }
}
