using System;

namespace Loops
{
    internal partial class Program
    {
        public class forloop {


            public void m1() {
                Console.WriteLine("--------------Prime No 1 t0 10------------------");
                for (int i=1;i<=10;i++) 
                {
                    if(i%2==0)
                    Console.WriteLine(i);
                }
                Console.WriteLine("---------------Prime No 10 to 1-----------------");
                for (int i = 10; i >= 1; i--)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }

                Console.WriteLine("-------------Prime No 100 to 50-------------");

                for (int i=70;i>=50;i--)
                {
                    if (i%2==0) 
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("----------Primme No 50 to 100------------");
                for (int i = 50; i <= 70; i++)
                {
                    if (i%2==0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }  
        }
    }
}
