using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class EmployeeDB : dbMngr
    {
        private string tableName;

        public EmployeeDB(string tableName)
        {
            this.tableName = tableName;
        }

        public string getTableName()
        {
            return this.tableName;
        }

        public void insertEmployee(employee emp)
        {
            string salary = emp.getSalary().ToString().Replace(",", ".");
            string query = "insert into calisanlar values(" + emp.getId().ToString() + ",'" + emp.getName() + "','"
                + emp.getSurname() + "'," + emp.getKategoriId().ToString() + ",'" + emp.getDoBirth() + "','" + emp.getDoStart()
                + "'," + salary + ")";

            executeCommand(query);
        }
         
        public void updateEmployee(employee emp)
        {
            string salary = emp.getSalary().ToString().Replace(",", ".");
            string query = "update calisanlar set id=" + emp.getId().ToString() + ", ad='" + emp.getName() + "', soyad='"
                + emp.getSurname() + "', kategori_id=" + emp.getKategoriId().ToString() + ", dogum_tarihi='" + emp.getDoBirth()
                + "', ise_baslama='" + emp.getDoStart() + "', maas=" + salary
                + " where id=" + emp.getId().ToString();

            executeCommand(query);
        }

        public void deleteEmployee(int emp_id)
        {
            string query = "delete from calisanlar where id=" + emp_id.ToString();

            executeCommand(query);
        }

        public DataTable searchYear(string dateColumn, string dateValue) 
        {
            string query = "select * from calisanlar where extract(year from " + dateColumn + ") =" + dateValue;
            return base.getData(query);
        }

        public DataTable searchMonth(string dateColumn, string dateValue)
        {
            string query = "select * from calisanlar where extract(month from " + dateColumn + ") =" + dateValue;
            return base.getData(query);
        }

        public DataTable searchYearMonth(string dateColumn, string dateValue)
        {
            string[] dateValues = dateValue.Split('-');
            string query = "select * from calisanlar where extract(year from " + dateColumn + ") =" + dateValues[0]
                + " and extract(month from " + dateColumn + ") =" + dateValues[1];
            return base.getData(query);
        }
    }
}
