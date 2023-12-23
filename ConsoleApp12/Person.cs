using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Person
    {
        public string Name { get; set; }
        public string Suname { get; set; }
        public string FathersName { get; set; }
        public int Age { get; set; }
        public string University { get; set; }
        public string Dog { get; set; }

        public void ShowFullName()
        {
            Console.WriteLine($"salam menim adim {Name} {Suname}-dir.{Age} yasimm var");
        }

        public Person(string name,string surname)
        {
            Name = name;
            Suname = surname;
        }

        public Person()
        {

        }
    }
}
