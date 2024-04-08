using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal partial class Conditional_Statement
    {
        public void Dailyrouting()
        {
            
            int hour = 20;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning");
            } else if (hour >=12 && hour<18) 
            {
                Console.WriteLine("It's After Noon");
            }
            else
            {
                Console.WriteLine("It's Eveaning");
            }
        }

        public void GoldPrice()
        {
            bool gold = true;

            String price = (gold) ? "i am gold customer" : "I am not gold  Customer";

            Console.WriteLine(price);
        
        }


    }
}
