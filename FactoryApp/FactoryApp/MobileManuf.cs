using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp
{
    class MobileManuf : Manufactorer
    {
        public MobileManuf(string name) : base(name)
        {
        }

        public override Product BuyProduct()
        {
            return new Mobile(name:Name);
        }
    }
}
