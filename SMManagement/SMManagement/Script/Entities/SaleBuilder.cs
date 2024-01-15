using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class SaleBuilder
    {
        private int id;
        private int customer_id;
        private string date;
        private float total;

        public static SaleBuilder startBuild()
        {
            return new SaleBuilder();
        }

        public sale build()
        {
            return new sale(this.id, this.customer_id, this.date, this.total);
        }

        public SaleBuilder setid(int id)
        {
            this.id = id;
            return this;
        }

        public SaleBuilder setCustomerId(int customer_id)
        {
            this.customer_id = customer_id;
            return this;
        }

        public SaleBuilder setDate(string date)
        {
            this.date = date;
            return this;
        }

        public SaleBuilder setTotal(float total)
        {
            this.total = total;
            return this;
        }
    }
}
