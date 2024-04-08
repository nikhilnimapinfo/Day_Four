using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    internal partial class Conditional_Statement
    {
        public class SwitchCaseProgram 
        {
            public void Operation()
            {
                var ses = sesion.Autumn;

                switch(ses)
                {
                    case sesion.Autumn:
                        Console.WriteLine("Is a Autumn");
                        break;

                    case sesion.Summer:
                        Console.WriteLine("It's Summer");
                        break;

                    case sesion.Spring:
                        Console.WriteLine("It's Spring");
                        break;

                    case sesion.Winter:
                        Console.WriteLine("It's Winter");
                        break;

                }


            }

            public void Days()
            {
                var ses = 2;

                switch (ses)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("Tusday");
                        break;

                    case 3:
                        Console.WriteLine("Wenesday");
                        break;

                    case 4:
                        Console.WriteLine("Thrusday");
                        break;

                    case 5:
                        Console.WriteLine("Friday");
                        break;


                }


            }

        }


    }
}
