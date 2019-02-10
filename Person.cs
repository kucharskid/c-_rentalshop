using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        protected Adress adress = new Adress();

        public Person(string name, string lastName, string phoneNumber, string emailAdress)
        {
            this.Name = name;
            this.Lastname = lastName;
            this.PhoneNumber = phoneNumber;
            this.EmailAdress = emailAdress;

        }

        public Person(string name, string lastName, string phoneNumber, string emailAdress,
            string city, string street, int number)
        {
            this.Name = name;
            this.Lastname = lastName;
            this.PhoneNumber = phoneNumber;
            this.EmailAdress = emailAdress;
            this.adress.City = city;
            this.adress.Street = street;
            this.adress.Number = number;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Lastname " + Lastname);
            Console.WriteLine("Phone number: " + PhoneNumber);
            Console.WriteLine("Email adress: " + EmailAdress);
            adress.Show();
        }
    }
}
