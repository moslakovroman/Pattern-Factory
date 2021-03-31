using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp
{
    abstract class Manufactorer
    {
        public string Name { get; set; }

        public Manufactorer(string name)
        {
            Name = name;
        }

        public abstract Product BuyProduct();
    }
}
