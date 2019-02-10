using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : Item
    {
        const string type = "Book";
        public string Type
        {
            get
            {
                return type;
            }
        }
        public string Author { get; set; }
        public ushort Pages { get; set; }

        public Book(string title, decimal price) :base(title, price) { }

        public Book(string title, string author, decimal price, ushort pages) :base(title, price)
        {
            this.Author = author;
            this.Pages = pages;
        }

        public override void Show()
        {
            Console.WriteLine("Type: " + Type);
            base.Show();
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Pages: " + Pages);
        }

    
    }
}
