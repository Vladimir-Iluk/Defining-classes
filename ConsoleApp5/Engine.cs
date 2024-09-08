class Engine
{
    public string modelEngine { get; set; }
    public int power { get; set; }
    public int kkd { get; set; }
    public Engine(string modelEngine, int power, int kkd)
    {
        this.modelEngine = modelEngine;
        this.power = power;
        this.kkd = kkd;
    }
    public Engine() { }
    List<Engine> engines = new List<Engine>();
    public void AddEngine(int n, List<Engine> engines)
    {
        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("Model engine - ");
            string modelEngine = Console.ReadLine();
            Console.WriteLine("Power - ");
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine("Kkd - ");
            int kkd = int.Parse(Console.ReadLine());
            Engine newEngine = new Engine(modelEngine, power, kkd);
            engines.Add(newEngine);
        }
    }
}
