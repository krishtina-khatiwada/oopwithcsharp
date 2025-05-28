class Bankaccount
{
    private double balance;

    public void Setbalance(double amount)
    {
        if (amount >= 0)
        {
            balance = amount;
        }
        else
        {
            Console.WriteLine("balance cannot be negative");
        }
    }
    public double Getbalance()
    {
        return balance;
    }
}
class Program
{
    static void Main()
    {
        Bankaccount b = new Bankaccount();
        b.Setbalance(1000);
        Console.WriteLine(b.Getbalance());
    }
}