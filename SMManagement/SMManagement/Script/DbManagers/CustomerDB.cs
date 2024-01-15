using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class CustomerDB : dbMngr
    {
        private string tableName;

        public CustomerDB(string tableName)
        {
            this.tableName = tableName;
        }

        public string getTableName()
        {
            return this.tableName;
        }

        public void insertCustomer(customer customer)
        {
            string query = "insert into musteri values(" + customer.getId().ToString() + ",'" + customer.getName() + "','"
                + customer.getSurname() + "','" + customer.getPhone() + "')";
            executeCommand(query);
        }

        public void updateCustomer(customer customer)
        {
            string query = "update musteri set id=" + customer.getId().ToString() + ", ad='" + customer.getName() + "',"
                + " soyad='" + customer.getSurname() + "', tel_no='" + customer.getPhone() + "'"
                + " where id=" + customer.getId().ToString();
            executeCommand(query);
        }

        
    }
}
