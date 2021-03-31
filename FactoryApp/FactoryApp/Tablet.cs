using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp
{
    class Tablet : Product
    {
        public Tablet(string name) : base(name)
        {
            Console.WriteLine($"you just already ordered the tablet - {name}");
        }
    }
}
