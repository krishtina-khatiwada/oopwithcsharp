interface ISwim
{
    void Icanswim();
}
interface IWalk
{
    void Icanwalk();
}
interface IFly
{
    void Icanfly();
}
class Dog : IWalk, ISwim
{
    public void Icanwalk()
    {
        Console.WriteLine("Dog can walk");
    }
    public void Icanswim()
    {
        Console.WriteLine("Dog can swim");
    }
}
class Parrot :IFly
{
    public void Icanfly()
    {
        Console.WriteLine("Parrot can fly");
    }
    
}
class Fish : ISwim
{
    public void Icanswim()
    {
        Console.WriteLine("fish can walk");
    }
    
}
class Program
{
    static void Main()
    {
        Dog d = new();
        Parrot p = new Parrot();
        Fish f = new Fish();
        d.Icanswim();
        d.Icanwalk();
        p.Icanfly();
        f.Icanswim();
        
    }
}