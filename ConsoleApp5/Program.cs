using System;

class Program
{
    static void Main()
    {
        Engine engine = new Engine();
        List<Engine> engines = new List<Engine>();
        Car car = new Car();
        List<Car> cars = new List<Car>();

        Console.WriteLine("Input how much engine - ");
        int n = int.Parse(Console.ReadLine());
        engine.AddEngine(n,engines); 
        
        Console.WriteLine("How much cars - ");
        int m = int.Parse(Console.ReadLine());
        car.AddCars(engines,m,cars);
        Console.WriteLine("\nCars added :");
        foreach (var addedCar in cars)
        {
            Console.WriteLine($"Model: {addedCar.model}:\n\tEngine : {addedCar.engine.modelEngine}\n\t\t Power : {addedCar.engine.power}\n\t\t Kkd : {addedCar.engine.kkd}\n\tWeight : {addedCar.weight} Color :{addedCar.color}");
        }
    }
}