namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car();

            car.Make = "Toyota";
            car.Model = "Landcruiser";
            car.Year = "1974";
            
            Console.WriteLine($"My first vehicle was a {car.Year} {car.Make} {car.Model}");
        }
    }
}
