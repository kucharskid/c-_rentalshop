using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Manager : Employee
    {
        public Manager(string name, string lastname, string phoneNumber, string emailAdress, decimal salary)
            : base(name, lastname, phoneNumber, emailAdress, salary) { }

        public Manager(string name, string lastname, string phoneNumber, string emailAdress, decimal salary,
            string city, string street, int number)
            : base(name, lastname, phoneNumber, emailAdress, salary, city, street, number) { }

        public void IncreaseSal(Staff s, decimal m)
        {
            s.Salary += m;
        }
        public void DecreaseSal(Staff s, decimal m)
        {
            s.Salary -= m;
        }

        public Seller HireSeller(string name, string lastName, string phoneNumber, string emailAdress, decimal salary)
        {
            return new Seller(base.Name = name, base.Lastname = lastName,
                base.PhoneNumber = phoneNumber, base.EmailAdress = emailAdress, base.Salary = salary);
        }

    }
}
