using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class SupplierDB : dbMngr
    {
        private string tableName;

        public SupplierDB(string tableName)
        {
            this.tableName = tableName;
        }

        public string getTableName()
        {
            return this.tableName;
        }

        public void insertSupplier(supplier supplier)
        {
            string query = "insert into tedarikci values(" + supplier.getId().ToString() + ",'" + supplier.getName() + "','"
                + supplier.getTelNo() + "','" + supplier.getAddress() + "')";

            executeCommand(query);
        }

        public void updateSupplier(supplier supplier)
        {
            string query = "update tedarikci set id=" + supplier.getId().ToString() + ",isim='" + supplier.getName()
                + "',tel_no='" + supplier.getTelNo() + "',address='" + supplier.getAddress() 
                + "' where id=" + supplier.getId().ToString();

            executeCommand(query);
        }

        
    }
}
