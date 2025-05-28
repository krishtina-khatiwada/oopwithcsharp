using System;
abstract class Shape
{
    public abstract int Area();
}
class Rectangle : Shape
{
    public int Width{ get; set; }
    public int Height{ get; set; }
    public override int Area()
    {
        return Width * Height;
    }
}
class Square : Shape
{
    public int Side { get; set; }
    public override int Area()
    {
        return Side * Side;
    }
}
class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle { Width = 5, Height = 4 };
        Square s = new Square();
        s.Side = 5;
        Console.WriteLine(s.Area());
        Console.WriteLine(r.Area());
    }
}