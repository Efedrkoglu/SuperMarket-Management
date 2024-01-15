using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class product 
    { 
        private int id;
        private string name;
        private string priceType;
        private float price;
        private bool stok;
        private int categoryID;
        private int supplierID;

        public product(int id, string name, string pirceType, float price, bool stok, int categoryID, int supplierID)
        {
            this.id = id;
            this.name = name;
            this.priceType = pirceType;
            this.price = price;
            this.stok = stok;
            this.categoryID = categoryID;
            this.supplierID = supplierID;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getPriceType()
        {
            return this.priceType;
        }

        public void setPriceType(string priceType)
        {
            this.priceType = priceType;
        }

        public float getPrice()
        {
            return this.price;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public bool isStok()
        {
            return this.stok;
        }

        public void setStok(bool stok)
        {
            this.stok = stok;
        }

        public int getCategoryID()
        {
            return this.categoryID;
        }

        public void setCategoryID(int categoryID)
        {
            this.categoryID = categoryID;
        }

        public int getSupplierID()
        {
            return this.supplierID;
        }

        public void setSupplierID(int supplierID)
        {
            this.supplierID = supplierID;
        }
    }
}
