using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class sale
    {
        private int id;
        private int customer_id;
        private string date;
        private float total;

        public sale(int id, int customer_id, string date, float total)
        {
            this.id = id;
            this.customer_id = customer_id;
            this.date = date;
            this.total = total;
        }

        public int getId()
        {
            return this.id;
        }

        public int getCustomerId()
        {
            return this.customer_id;
        }

        public string getDate()
        {
            return this.date;
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
