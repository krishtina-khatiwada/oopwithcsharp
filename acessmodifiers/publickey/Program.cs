using System.Diagnostics.Contracts;

class Div()
{
    public int a;
    public int b;

}
class Program()
{
    static void Main()
    {
        var d = new Div();
        int c;
        d.a = 5;
        d.b = 5;
        c = d.a / d.b;
        Console.WriteLine(c);
        
        

    }
}