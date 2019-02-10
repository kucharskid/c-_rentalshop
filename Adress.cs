using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public void Show()
        {
            Console.WriteLine("City: " + City);
            Console.WriteLine("Street: " + Street);
            Console.WriteLine("Number: " + Number);
        }
    }
}
