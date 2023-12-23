using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Qurban","Qurbanov");
            /* person1.Name = "Qurban";
             person1.Suname = "Qurbanov";
             person1.FathersName = "Musa";
             person1.University = "IdmanAka";
             person1.Age = 50;*/

            Person person2 = new Person("huseyn","Sultanli");
           /* {
                Name="Huseyn",
                Suname="Sultanli",
                FathersName="Vuqar",
                Age=19,
                University="Azmiu",

            };*/

            Console.WriteLine(person1.Age+person2.Age);

            Person[] persons = { person1, person2 };

            foreach (var person in persons)
            {
                person.ShowFullName();

            }

            Car car1 = new Car()
            {
                Brand = "Porshe",
                Model = "911",
                Color = "Blue",
                MaxSpeed=350
            };

            Car[] cars = { car1 };

            foreach (var car in cars)
            {
                Console.WriteLine($"the model of car is {car.Brand} {car.Model}");
            }
            
        }
    }
}
