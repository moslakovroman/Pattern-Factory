using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp
{
    class NotebookManuf : Manufactorer
    {
        public NotebookManuf(string name) : base(name)
        {
        }

        public override Product BuyProduct()
        {
            return new Notebook(name:Name);
        }
    }
}
