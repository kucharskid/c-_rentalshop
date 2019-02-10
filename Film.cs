using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Film : Item
    {
        public const string type = "Film";
        public string Type
        {
            get
            {
                return type;
            }
        }
        public string Medium { get; set; }
        public ushort Lenght { get; set; }
        public string Director { get; set; }

        public Film(string title, decimal price) : base(title, price) { }

        public Film(string medium, string title, string director, decimal price, ushort lenght) :base(title, price)
        {
            this.Medium = medium;
            this.Director = director;
            this.Lenght = lenght;
        }

        public override void Show()
        {
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Medium: " + Medium);
            base.Show();
            Console.WriteLine(Director);
            Console.WriteLine("Lenght: " + Lenght + " min.");
        }

      
    }
}
