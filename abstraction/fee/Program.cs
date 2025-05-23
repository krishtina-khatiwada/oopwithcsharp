interface IFees
{
    void Fee(int amount);
}
class Pay : IFees
{
    public void Fee(int amount)
    {
        Console.WriteLine("your fee is " + amount);
    }
    
}
class Program
{
    static void Main()
    {
        IFees f = new Pay();
        f.Fee(1000);
    }
}