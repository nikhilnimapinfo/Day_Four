using System;

namespace Loops
{
    internal partial class Program
    {
        public class foreachloop {
            public void m1() 
            {
                Console.WriteLine("-------------Using For Loop--------------");
                var name= "Nimap";
                for (var i=0;i<=name.Length-1;i++)
                {
                    Console.WriteLine(name[i]);
                }
                Console.WriteLine("--------------Using For Each Loop-----------------");

                foreach (var value in name)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("-------------Iterate array-------------");

                int[] arr = new int[] { 1,2,3,4,5,6};
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
