using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    public class Person
    {
        public int age;
    }
    internal class Class1
    {
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void makeOld(Person person)
        {
            person.age += 10;
        }
    }
}
