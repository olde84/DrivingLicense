using System;
using static System.Console;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            License();
        }
        public static void License()
        {
            Person person = new();
            WriteLine(person.Vehicle());
            ReadKey();
        }
    }
}
