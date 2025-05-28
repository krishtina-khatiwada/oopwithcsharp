class Bell
{
    public static readonly Bell _ring = new Bell();
    private Bell()
    {

    }
    public static Bell Instance
    {
        get { return _ring; }
    }
    public void Ring() {
        Console.WriteLine("class starts");
    }

}
class Program {
    static void Main()
    {
        Bell B1 = Bell.Instance;
        Bell B2 = Bell.Instance;
        B1.Ring();
        Console.WriteLine(B1 == B2);

    
}
}