interface IEngine
{
    void Start();
}
class Petrolengine : IEngine
{
    public void Start()
    {
        Console.WriteLine("petrol engine started");

    }
}
class Electricengine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Electric engine started");

    }
}
class Car
{
    private IEngine engine;
    public Car(IEngine engine)
    {
        this.engine = engine;
    }
    public void Startcar()
    {
        engine.Start();
    }

}


class Program
{
    static void Main()
    {
        IEngine engine = new Electricengine();
        IEngine engine1 = new Petrolengine();
        Car c = new Car(engine1);
        Car c1 = new Car(engine);
        c.Startcar();
        c1.Startcar();
    }
}
