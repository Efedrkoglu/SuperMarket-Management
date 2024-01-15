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
    public partial class Login : Form
    {
        private UserDB udb;
        public Login()
        {
            InitializeComponent();
            udb = (UserDB)DbFactory.getDb("users");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(udb.authenticate(tb_userName.Text, tb_password.Text, rb_admin.Checked))
            {
                if(rb_admin.Checked)
                {
                    new AdminPanel(this).Show();
                    rb_user.Checked = true;
                    this.Hide();
                }
                else if(rb_user.Checked)
                {
                    new UserPanel(this).Show();
                    rb_user.Checked = true;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }

            tb_userName.Text = "";
            tb_password.Text = "";
        }
    }
}
