namespace Vehicle_Inheritance_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var car = new Car ();

            car.Model = "Toyota";
            car.Start();
            car.Stop();


            var motorcycle = new Motorcycle ();
            motorcycle.Model = "Kawasaki";
            motorcycle.Start();
            motorcycle.Stop();
        }
    }
}