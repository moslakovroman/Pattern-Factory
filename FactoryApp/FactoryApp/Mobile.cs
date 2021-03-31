using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp
{
    class Mobile :Product
    {
        public Mobile(string name) : base(name)
        {
            Console.WriteLine($"you just already ordered mobile phone - {name}");
        }
    }
}
