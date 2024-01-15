using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class CategoryDB : dbMngr
    {
        private string tableName;

        public CategoryDB(string tableName)
        {
            this.tableName = tableName;
        }

        public string getTableName()
        {
            return this.tableName;
        }

        public void insertCategory(category category)
        {
            string query = "insert into kategori values(" + category.getId().ToString() + ", '" + category.getName() + "')";

            executeCommand(query);
        }

        public void updateCategory(category category)
        {
            string query = "update kategori set id=" + category.getId().ToString() + ", name='" + category.getName() + "'" 
                + " where id=" + category.getId().ToString();

            executeCommand(query);
        }      
    }
}
