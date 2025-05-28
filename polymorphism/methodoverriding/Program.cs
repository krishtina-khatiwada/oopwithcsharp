class Bank
{
    public virtual void Interestrate()
    {
        Console.WriteLine("the rate of interest is 3%");
    }
}
class Nabil:Bank
{
    public override void Interestrate()
    {
        Console.WriteLine("the rate of interest is 4%");
    }
}
class Citizen : Bank
{
    public override void Interestrate()
    {
        Console.WriteLine("the rate of interest is 5%");
    }
}
class Program
{
    static void Main()
    {
        Nabil N = new Nabil();
        Citizen c = new Citizen();
        Bank b = new Bank();
        N.Interestrate();
        c.Interestrate();
        b.Interestrate();
    }
}
