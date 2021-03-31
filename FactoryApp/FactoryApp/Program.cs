using System;

namespace FactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileBuyer = new MobileManuf("Samsung");
            var samsung = mobileBuyer.BuyProduct();
            Console.WriteLine(new string('-', 30));

            var otherPhone = mobileBuyer.Name = "iPhone";
            var iPhone = mobileBuyer.BuyProduct();
            Console.WriteLine(new string('-', 30));

            var notebookBuyer = new NotebookManuf("MSI");
            var msi = notebookBuyer.BuyProduct();
            Console.WriteLine(new string('-', 30));

            var tabletBuyer = new TabletManuf("iPad");
            var iPad = tabletBuyer.BuyProduct();
        }
    }
}
