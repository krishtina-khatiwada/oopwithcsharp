interface Ifly
{
    void Ifly();
}

class Bird
{

}
class Parrot : Bird, Ifly
{
    public void Ifly()
    {
        Console.WriteLine("This bird can fly");
    }
}
class Penguin:Bird
{
    public void Pen()
    {
        Console.WriteLine("penguin cannot fly");
    }
}
class Program
{
    static void Main()
    {
        Parrot p = new Parrot();
        p.Ifly();
        Penguin Pe = new Penguin();
        Pe.Pen();
    }
}