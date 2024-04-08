using System;

namespace Task
{
    public partial class task3 {
     
        public void m1 ()
        {
            Console.WriteLine("Enter A heigh Of Picture");
            int height=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter A Width Of Picture");
            int  width= Convert.ToInt32(Console.ReadLine());

            if (height >= width)
            {
                Console.WriteLine("Image is Portrait Mode");
            }
            else {
                Console.WriteLine("Image is LandScape Mode");

            }
        }
    
    
    }
}
