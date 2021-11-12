using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Custtomer custtomer = new Custtomer("Levon");
            Atm atm = new Atm();
            Console.WriteLine(custtomer.Name);
            atm.cashIn(100);
            atm.cashIn(0);
            atm.cashOut(24);
            atm.cashOut(5000);
            Console.WriteLine();
            Console.ReadKey();
               
        }
    }
}
