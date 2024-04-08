using System;

namespace Task
{
    public partial class task4
    {
            public void program()
            {
                Console.WriteLine("Enter Speed Limit");
                int speedlimit=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Speed Limit is :"+ speedlimit);

                Console.WriteLine("Enter Speed Of Car ");
                int carspeed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Car Speed is :" + carspeed);

                int Points = 0;
                if (carspeed<speedlimit)
                {
                    Console.WriteLine("Speed IS Okey");
                }
                else {
                    int Speeddiff =carspeed-speedlimit;

                    for (int counter = 5; counter <= Speeddiff; counter += 1)
                    {
                        if (counter % 5 == 0)
                        {
                            Points++;
                        }                    
                    }
                }
                Console.WriteLine("demerit points :" +Points);
                if (Points <= 12)
                {
                    Console.WriteLine("Your Licens is Not Suspended");
                }
                else {
                    Console.WriteLine("Your License is Suspended ");
                }

            }    
    }
}
