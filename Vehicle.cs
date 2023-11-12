using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance_Excercise
{
    public abstract class Vehicle
    {
        // TODO: zdefiniuj wspólne części klas pochodnych
        public int Model { get; set; }
        //public int Sits { get; set; }

        //public int Wheels { get; set; }

        //public string Color { get; set; }

        public abstract void Start();

        public abstract void Stop();

    }

    public class Car : Vehicle
    {
        // TODO: Uzupełnij implementację klasy Car, aby dziedziczyła po klasie Vehicle,
        // posiadała implementacje metod Start i Stop, oraz dodatkowe metody związane z samochodem.
        
    }

    public class Motorcycle : Vehicle
    {
        // TODO: Uzupełnij implementację klasy Motorcycle, aby dziedziczyła po klasie Vehicle,
        // posiadała implementacje metod Start i Stop, oraz dodatkowe metody związane z motocyklem.
    }

}
