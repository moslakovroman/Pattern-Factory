using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp
{
    class Notebook : Product
    {
        public Notebook(string name) : base(name)
        {
            Console.WriteLine($"you just already ordered notebook - {name}");
        }
    }
}
