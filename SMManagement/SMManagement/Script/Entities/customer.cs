using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class customer
    {
        private int id;
        private string name;
        private string surname;
        private string phone;

        public customer(int id, string name, string surname, string phone)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
        }
        
        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public string getPhone()
        {
            return this.phone;
        }
    }
}
