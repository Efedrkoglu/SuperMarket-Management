using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMManagement.Script
{
    internal abstract class dbMngr
    {
        private NpgsqlConnection conn = new NpgsqlConnection("server=localhost; port=5432; Database=postgres; user ID=postgres; password=passwd");
        private NpgsqlDataAdapter da;
        private NpgsqlCommand cmd;

        public DataTable getData(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                da = new NpgsqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public DataTable selectAll(string tableName)
        {
            string query = "select * from " + tableName + " order by id";
            return getData(query);
        }

        public DataTable search(string tableName, string columnName, string columnValue)
        {
            string query = "select * from " + tableName + " where " + columnName + "=" + columnValue;
            return getData(query);
        }

        public DataTable searchStr(string tableName, string columnName, string columnValue)
        {
            string query = "select * from " + tableName + " where " + columnName + "='" + columnValue + "'";
            return getData(query);
        }

        public DataTable wildSearch(string tableName, string propName, string propValue)
        {
            string query = "select * from " + tableName + " where " + propName + " ilike '%" + propValue + "%'";
            return getData(query);
        }

        public void executeCommand(string query)
        {
            cmd = new NpgsqlCommand(query, conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
