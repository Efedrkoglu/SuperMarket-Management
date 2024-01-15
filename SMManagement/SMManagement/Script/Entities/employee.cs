using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMManagement.Script
{
    internal class employee
    {
        private int id;
        private string name;
        private string surname;
        private int kategori_id;
        private string doBirth;
        private string doStart;
        private float salary;

        public employee(int id, string name, string surname, int kategori_id, string doBirth, string doStart, float salary)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.kategori_id = kategori_id;
            this.doBirth = doBirth;
            this.doStart = doStart;
            this.salary = salary;
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

        public int getKategoriId()
        {
            return this.kategori_id;
        }

        public string getDoBirth()
        {
            return this.doBirth;
        }

        public string getDoStart()
        {
            return this.doStart;
        }

        public float getSalary()
        {
            return this.salary;
        }

    }
}
