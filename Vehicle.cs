using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance_Excercise
{
    public abstract class Vehicle
    {
        // TODO: zdefiniuj wspólne części klas pochodnych
        public string Model { get; set; }

        public abstract void Start();

        public abstract void Stop();

    }

    public class Car : Vehicle
    {
        // TODO: Uzupełnij implementację klasy Car, aby dziedziczyła po klasie Vehicle,
        // posiadała implementacje metod Start i Stop, oraz dodatkowe metody związane z samochodem.
        //public string Model { get; set; }

        string Model = "ttt";

        public override void Start ()
        {
            Console.WriteLine($"Starting the car: {Model}");
        }

        public override void Stop ()
        {
            Console.WriteLine($"Stopping the car: {Model}");
        }
    }

    public class Motorcycle : Vehicle
    {
        // TODO: Uzupełnij implementację klasy Motorcycle, aby dziedziczyła po klasie Vehicle,
        // posiadała implementacje metod Start i Stop, oraz dodatkowe metody związane z motocyklem.
        public override void Start ()
        {
            Console.WriteLine($"Starting the motorcycle: {Model}");
        }

        public override void Stop ()
        {
            Console.WriteLine($"Stopping the motorcycle: {Model}");
        }
    }

}



