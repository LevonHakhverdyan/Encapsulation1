using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    public class BankOperations : Custtomer
    {
        
        public void cashIn(double sum)
        {
            
            if (sum <= 0)
            {
                Console.WriteLine("value cannot be negative");
            }
            else
            {
                Balance += sum;
                Console.WriteLine($" you have replenishhed {sum} the balance is {Balance}");
            }

        }
        public void cashOut(double sum)
        {
            if (sum <= Balance)
            {
                Balance -= sum;
                Console.WriteLine($"you cashed {sum} the balance is {Balance}");
                
            }
            else
                Console.WriteLine($"You don't have enough money on your balance the balance is {Balance}");
            
        }
    }
}
