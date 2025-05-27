using System.Runtime;

class Credit
{
    public int Takemoney(int amount)
    {
        Console.WriteLine($"you have amount {amount}");
        return amount;
    }
}
class Debit
{
    public int Withdraw(int amount)
    {

        Console.WriteLine($"you can withdraw {amount}");
        return amount;
    }
}
class Program {
    static void Main()
    {
        Credit c = new Credit();
        Debit d = new Debit();
        int cred=c.Takemoney(10000);
        d.Withdraw(cred);
    }
}