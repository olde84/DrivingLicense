using System;
using static System.Console;
using static System.Convert;

namespace DrivingLicense
{
    class Person
    {
        public int Age { get; private set; }
        public string Name { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public Person()
        {

        }

        public Person PersonNameAndAge()
        {
            WriteLine("Enter your name");
            string name = ReadLine();
            WriteLine("Enter your age");
            int age = ToInt32(ReadLine());
            return new(age, name);
        }

        public string Vehicle()
        {
            Person p = PersonNameAndAge();
            if (p.Age == 15)
            {
                return $"Hej {p.Name} när man är {p.Age} år så har man AM behörighet.";
            }
            else if (p.Age >= 16 && p.Age < 18)
            {
                return $"Hej {p.Name} när man är {p.Age} år så har man AM och A1 behörighet.";
            }
            else if (p.Age == 18 && p.Age < 21)
            {
                return $"Hej {p.Name} när man är {p.Age} år så har man AM, A1, A2, BE och B behörighet.";
            }
            else if (p.Age == 20)
            {
                return $"Hej {p.Name} när man är {p.Age} år så har man AM, A1, A2, BE, B och A om du har haft A2 i över 2 år behörighet.";
            }
            else if (p.Age >= 21 && p.Age < 24)
            {
                return $"Hej {p.Name} när man är {p.Age} år så har man AM, A1, A2, BE, B, C, CE behörighet.";
            }
            else if (p.Age >= 24)
            {
                return $"Hej {p.Name} när man är {p.Age} år så har man AM, A1, A2, BE, B, C, CE, A, D och DE behörighet.";
            }
            else
            {
                return $"Hej {p.Name} du är bara {p.Age} år din bebis.";
            }
        }
    }
}
