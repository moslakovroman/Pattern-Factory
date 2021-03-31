using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp
{
    class TabletManuf : Manufactorer
    {
        public TabletManuf(string name) : base(name)
        {
        }

        public override Product BuyProduct()
        {
            return new Tablet(name:Name);
        }
    }
}
