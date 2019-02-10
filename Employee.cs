using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Employee : Person
    {
        public decimal Salary { get; protected internal set; }

        public Employee(string name, string lastname, string phoneNumber, string emailAdress, decimal salary)
            : base(name, lastname, phoneNumber, emailAdress)
        {
            this.Salary = salary;
        }

        public Employee(string name, string lastname, string phoneNumber, string emailAdress, decimal salary,
            string city, string street, int number)
            : base(name, lastname, phoneNumber, emailAdress)
        {
            this.Salary = salary;
            base.adress.City = city;
            base.adress.Street = street;
            base.adress.Number = number;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Salary: " + Salary + '$');
        }
    }
}
