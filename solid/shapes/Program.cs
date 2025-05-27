using System;
abstract class Shape
{
    public abstract int Area();
}
class Rectangle : Shape
{
    public virtual int Width{ get; set; }
    public virtual int Height{ get; set; }
    public override int Area()
    {
        return Width * Height;
    }
}
class Square : Rectangle
{
    public override int Width {
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }
    public override int Height{
        set
        {
            base.Width=value;
            base.Height=value;
        }
    }
}
class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle { Width = 5, Height = 4 };
        Square s = new Square();
        s.Width = 5;
        Console.WriteLine(s.Area());
        Console.WriteLine(r.Area());
    }
}