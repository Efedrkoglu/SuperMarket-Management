using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class saleDetail
    {
        private int id;
        private int sale_id;
        private int product_id;
        private float productPrice;
        private float amount;
        private float total;

        public saleDetail(int sale_id, int product_id, float amount)
        {
            this.sale_id = sale_id;
            this.product_id = product_id;
            this.amount = amount;
        }

        public saleDetail(int id, int sale_id, int product_id, float amount)
        {
            this.id = id;
            this.sale_id = sale_id;
            this.product_id = product_id;
            this.amount = amount;
        }

        public saleDetail(int id, int sale_id, int product_id, float productPrice, float amount, float total) 
        {
            this.id = id;
            this.sale_id = sale_id;
            this.product_id = product_id;
            this.productPrice = productPrice;
            this.amount = amount;
            this.total = total;
        }

        public int getId()
        {
            return this.id;
        }

        public int getSaleId()
        {
            return this.sale_id;
        }

        public int getProductId()
        {
            return this.product_id;
        }

        public float getProductPrice()
        {
            return this.productPrice;
        }

        public float getAmount()
        {
            return this.amount;
        }

        public void setAmount(float amount)
        {
            this.amount = amount;
        }

        public float getTotal()
        {
            return this.total;
        }

        public void setTotal(float total)
        {
            this.total = total;
        }
    }
}
