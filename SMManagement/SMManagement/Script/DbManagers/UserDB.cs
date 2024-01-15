using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class UserDB : dbMngr
    {
        private string tableName;

        public UserDB(string tableName)
        {
            this.tableName = tableName;
        }

        public bool authenticate(string userName, string password, bool isAdmin)
        {
            string query = "select user_name, password from (select user_name, password from users where isAdmin=" + isAdmin.ToString()
                + ") as x where user_name='" + userName + "' and password='" + password + "'";

            DataTable dt = base.getData(query);
            return dt.Rows.Count > 0;
        }
    }
}
