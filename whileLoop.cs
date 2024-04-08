using System;

namespace Loops
{
    internal partial class Program
    {
        public partial class whileLoop {
            public void m2()
            {
                while (true)
                {
                    Console.WriteLine("Enter Name :");
                    var value = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(value))
                    {
                        break;
                    }
                    Console.WriteLine("Name :"+value);

                }

            }
        
        }
        
    }
}
