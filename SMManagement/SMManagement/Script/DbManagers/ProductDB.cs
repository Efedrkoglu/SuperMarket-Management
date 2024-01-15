using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class ProductDB : dbMngr
    {
        private string tableName;
        public ProductDB(string tableName)
        {
            this.tableName = tableName;
        }

        public string getTableName()
        {
            return this.tableName;
        }

        public void insertProduct(product product)
        {
            string price = product.getPrice().ToString().Replace(",", "."); ;
            string query = "insert into urunler values(" + product.getId().ToString() + ",'" + product.getName() + "','" +
                product.getPriceType() + "'," + price + "," + product.isStok().ToString() + "," +
                product.getCategoryID().ToString() + "," + product.getSupplierID().ToString() + ")";

            executeCommand(query);
        }

        public void updateProduct(product product)
        {
            string price = product.getPrice().ToString().Replace(",", "."); ;
            string query = "update urunler " +
                "set id=" + product.getId().ToString() + ", isim='" + product.getName() + "', fiyat_tip='" + 
                product.getPriceType() + "', " +
                "fiyat=" + price + ", stok=" + product.isStok().ToString() + ", kategori_id=" +
                product.getCategoryID().ToString() + ", tedarikci_id=" + product.getSupplierID().ToString() +
                " where id=" + product.getId().ToString();

            executeCommand(query);
        }

    }
}
