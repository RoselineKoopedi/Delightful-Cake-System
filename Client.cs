using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelightFul_Cake
{
    class Client
    {
        private string name;
        private string surname;
        private string contact;
        private string cake_Name;
        private double price;
        private string description;
        private string coke_Name;
        private DateTime date;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string Cake_Name
        {
            get
            {
                return cake_Name;
            }

            set
            {
                cake_Name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Coke_Name
        {
            get
            {
                return coke_Name;
            }

            set
            {
                coke_Name = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public Client()
        {

        }
        public Client(string n,string s, string contacts, string c,double p,string d,string co,DateTime dat)
        {
            this.name=n;
            this.surname = s;
            this.contact = contacts;
            this.cake_Name = c;
            this.price = p;
            this.description = d;
            this.coke_Name = co;
            this.date = dat;
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",name,surname,contact,cake_Name,price,description,coke_Name,date);
        }
    }
}
