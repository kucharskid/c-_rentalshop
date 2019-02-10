using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Item
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; } = true;

        public Item(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }

        ~Item()
        {
            Console.WriteLine("The item no longer exists in our resources");
        }

        public virtual void Show()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Price $: " + Price);
        }
       
    }
}
