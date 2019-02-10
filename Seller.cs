using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Seller : Staff
    {

        public Seller(string name, string lastname, string phoneNumber, string emailAdress, decimal salary)
            : base(name, lastname, phoneNumber, emailAdress, salary) { }

        public Seller(string name, string lastname, string phoneNumber, string emailAdress, decimal salary,
            string city, string street, int number)
            : base(name, lastname, phoneNumber, emailAdress, salary, city, street, number) { }


        public void AddItem(Customer c ,Item x)
        {
            if (x.Available == true)
            {
                c.itemList.Add(x);
                x.Available = false;
                c.Debt += c.DiscountPrice(x);
            }
            else
            {
                Console.WriteLine("This item is not available!");
            }
        }

        public void ResetDebt(Customer c)

        {
            c.Debt = 0;
        }
    }
}
