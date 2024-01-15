using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class SalesDB : dbMngr
    {
        private string tableName;

        public SalesDB(string tableName)
        {
            this.tableName = tableName;
        }

        public string getTableName()
        {
            return this.tableName;
        }

        public DataTable getMaxId()
        {
            string query = "select max(id) from satis";
            return base.getData(query);
        }

        public DataTable getSaleDetails(sale sale)
        {
            string query = "select satis_detay.id, urunler.isim, satis_detay.urun_id, satis_detay.urun_fiyat, " +
                "satis_detay.miktar, satis_detay.toplam from satis_detay inner join urunler" +
                " on satis_detay.urun_id = urunler.id" +
                " where satis_id = " + sale.getId().ToString();
            return base.getData(query);
        }

        public void insertSale(sale sale)
        {
            string query = "insert into satis values(default," + sale.getCustomerId().ToString() + ", '" + sale.getDate()
                + "', " + sale.getTotal().ToString() + ")";

            executeCommand(query);
        }

        public void insertSaleNullCustomer(sale sale)
        {
            string query = "insert into satis values(default, null, '" + sale.getDate()
                + "', " + sale.getTotal().ToString() + ")";

            executeCommand(query);
        }

        public void insertSaleDetail(saleDetail sd)
        {
            string amount = sd.getAmount().ToString().Replace(",", ".");
            string query = "insert into satis_detay values(default, " + sd.getSaleId().ToString() + ", "
                 + sd.getProductId().ToString() + ", (select fiyat from urunler where id =" + sd.getProductId().ToString() + ")"
                 + ", " + amount + ", (select fiyat from urunler where id = " + sd.getProductId().ToString() + ")*" + amount + ")";

            executeCommand(query);
        }

        public void updateSaleDetail(saleDetail sd)
        {
            string amount = sd.getAmount().ToString().Replace(",", ".");
            string query = "update satis_detay set urun_id=" + sd.getProductId().ToString() + ", urun_fiyat="
                + "(select fiyat from urunler where id=" + sd.getProductId().ToString() + "), miktar=" + amount
                + ", toplam=(select fiyat from urunler where id=" + sd.getProductId().ToString() + ")*" + amount
                + " where id=" + sd.getId().ToString();

            executeCommand(query);
        }

        public void deleteSaleDetail(int saleDetailId)
        {
            string query = "delete from satis_detay where id=" + saleDetailId.ToString();
            executeCommand(query);
        }

        public void cancelSale(sale sale)
        {
            clearSaleDetail(sale.getId());
            deleteSale(sale.getId());
        }

        public void clearSaleDetail(int saleId)
        {
            string query = "delete from satis_detay where satis_id=" + saleId.ToString();
            executeCommand(query);
        }

        public void deleteSale(int saleId)
        {
            string query = "delete from satis where id=" + saleId.ToString();
            executeCommand(query);
        }

        public void completeSale(sale sale)
        {
            string query = "update satis set tutar= (select sum(toplam) from satis_detay where satis_id=" + sale.getId().ToString()
                + ") where id=" + sale.getId().ToString();

            executeCommand(query);
        }

        public DataTable searchYear(string dateColumn, string dateValue)
        {
            string query = "select * from satis where extract(year from " + dateColumn + ") =" + dateValue;
            return base.getData(query);
        }

        public DataTable searchYearMonth(string dateColumn, string dateValue)
        {
            string[] dateValues = dateValue.Split('-');
            string query = "select * from satis where extract(year from " + dateColumn + ") =" + dateValues[0]
                + " and extract(month from " + dateColumn + ") =" + dateValues[1];
            return base.getData(query);
        }
    }
}
