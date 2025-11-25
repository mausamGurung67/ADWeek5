namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car object
            Car car = new Car();
            car.Brand = "Toyota";
            car.Speed = 120;
            car.Seats = 5;

            Console.WriteLine("Car Info");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            // Motorcycle object
            Motorcycle moto = new Motorcycle();
            moto.Brand = "Yamaha";
            moto.Speed = 90;
            moto.HasCarrier = true;

            Console.WriteLine("Motorcycle Info");
            moto.Start();
            moto.DisplayInfo();
            moto.Stop();

            Console.WriteLine();
        }
    }
}
