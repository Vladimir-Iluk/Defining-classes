class Car
{
    public string model { get; set; }
    public Engine engine { get; set; }
    public int weight { get; set; }
    public string color { get; set; }
    public Car(string model, Engine engine, int weight, string color)
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }
    public Car() { }
    //List<Car> cars = new List<Car>();

    public void AddCars(List<Engine> engines, int m, List<Car> cars)
    {
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Model car - ");
            string model = Console.ReadLine();
            Console.WriteLine("Weight car - ");
            int weight = int.Parse(Console.ReadLine());
            Engine selectedEngine = null;
            while (selectedEngine == null)
            {
                Console.WriteLine("Model engine - ");
                string typeEngine = Console.ReadLine();

                var selectEngine = from e in engines
                                   where e.modelEngine == typeEngine
                                   select e;
                selectedEngine = selectEngine.FirstOrDefault();
                if (selectedEngine == null)
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.WriteLine("Color car - ");
            string color = Console.ReadLine();

            Car newCar = new Car(model, selectedEngine, weight, color);
            cars.Add(newCar);

        }
    }
}