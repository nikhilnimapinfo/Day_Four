using System;

namespace Task
{
    internal partial class Program
    {
        public class task2 {
            public void m1()
            {
                Console.WriteLine("Enter Value");
                int x=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Value");
                int y=Convert.ToInt32(Console.ReadLine());

                if (x > y)
                {
                    Console.WriteLine("Maximum Value is :" + x);
                }
                else {
                    Console.WriteLine("Maximum Value is :" + y);
                }


            }
        
        
        }
    }
}
