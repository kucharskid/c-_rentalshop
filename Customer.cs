using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Customer : Person
    {
        public decimal Discount { get; set; } // %

        public decimal Debt { get; set; } = 0; // $

        protected internal List<Item> itemList = new List<Item>();


        public Customer(string name, string lastname, string phoneNumber, string emailAdress, byte discount)
            : base(name, lastname, phoneNumber, emailAdress)
        {
            this.Discount = discount;
        }

        public Customer(string name, string lastname, string phoneNumber, string emailAdress, byte discount,
            string city, string street, int number)
            : base(name, lastname, phoneNumber, emailAdress, city, street, number)
        {
            this.Discount = discount;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Discount: " + Discount + '%');
            Console.WriteLine("Debt: $" + Debt);
        }


        public void ReturnItem(Item x)
        {
            if (itemList.Contains(x))
            {
                itemList.Remove(x);
                x.Available = true;
            }
            else
            {
                Console.WriteLine("The customer doesn't have the item!");
            }
        }

        public void ShowItem()
        {
            foreach (Item oItem in itemList)
            {
                Console.WriteLine("Title: " + oItem.Title);
            }
        }

        public void PayDebt(decimal x)
        {
            Debt -= x;
        }

       

        public decimal DiscountPrice(Item x)
        {
            decimal newPrice = x.Price - (x.Price * (Discount / 100));
            return newPrice;
        }
    }
}
