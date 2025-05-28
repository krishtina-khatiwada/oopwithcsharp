abstract class Discount
{
    public abstract void getdiscount();
}
class Studentdiscount : Discount
{
    public override void getdiscount()
    {
        Console.WriteLine("your discoount amount is 10%");
    }
}
class Memberdiscount : Discount
{
    public override void getdiscount()
    {
        Console.WriteLine("your discount amount is 12%");
    }
}
class Program
{
    static void Main()
    {
        
        Studentdiscount sd = new Studentdiscount();
        Memberdiscount md = new Memberdiscount();
        sd.getdiscount();
        md.getdiscount();
    }
}