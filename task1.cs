using System;

namespace Task
{
    internal partial class Program
    {
        public class task1 {

            public void m1() 
            {
                Console.WriteLine("Enter Some Value");
                int i= Convert.ToInt32(Console.ReadLine());

                if (i <= 10)
                {
                    Console.WriteLine("Is A valid value");

                }
                else {
                    Console.WriteLine("It's Not Valid Value");
                }
            }
        }
    }
}
