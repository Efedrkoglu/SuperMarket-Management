using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class supplier
    {
        private int id;
        private string name;
        private string tel_no;
        private string address;

        public supplier(int id, string name, string tel_no, string address)
        {
            this.id = id;
            this.name = name;
            this.tel_no = tel_no;
            this.address = address;
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

        public string getTelNo()
        {
            return this.tel_no;
        }

        public void setTelNo(string tel_no)
        {
            this.tel_no = tel_no;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
    }
}
