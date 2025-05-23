class Number
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    public string Sum(string a, string b)
    {
        return a + b;
    }
}
class Program
{
    static void Main()
    {
        Number N = new Number();
        Console.WriteLine(N.Sum(2, 3));
        Console.WriteLine(N.Sum(2, 3,4));
        Console.WriteLine(N.Sum("good", "day"));
    }
}
