using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class DbFactory
    {
        public static dbMngr getDb(string tableName)
        {
            if(tableName.Equals("urunler"))
            {
                return new ProductDB(tableName);
            }
            else if(tableName.Equals("tedarikci")) {
                return new SupplierDB(tableName);
            }
            else if (tableName.Equals("kategori")) {
                return new CategoryDB(tableName);
            }
            else if (tableName.Equals("calisanlar"))
            {
                return new EmployeeDB(tableName);
            }
            else if (tableName.Equals("satis"))
            {
                return new SalesDB(tableName);
            }
            else if (tableName.Equals("musteri"))
            {
                return new CustomerDB(tableName);
            }
            else if (tableName.Equals("users"))
            {
                return new UserDB(tableName);
            }
            else
            {
                throw new Exception("Gecersiz tablo adı!");
            }
        }
    }
}
