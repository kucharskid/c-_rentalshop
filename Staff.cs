using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Staff : Employee
    {
        public Staff(string name, string lastname, string phoneNumber, string emailAdress, decimal salary)
            : base(name, lastname, phoneNumber, emailAdress, salary) { }

        public Staff(string name, string lastname, string phoneNumber, string emailAdress, decimal salary,
            string city, string street, int number)
            : base(name, lastname, phoneNumber, emailAdress, salary, city, street, number) { }
    }
}
