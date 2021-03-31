using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace FactoryApp
{
    abstract class Product
    {
        public string ProductCategory { get; set; }

        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }

    }
}
