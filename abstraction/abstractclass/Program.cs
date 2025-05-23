abstract class Student
{
    public abstract void Record();
}
class Subject : Student
{
    public override void Record()
    {
        string subname = "C sharp";
        Console.WriteLine("sub name is " + subname);
    }
}
class Program
{
    static void Main()
    {
        Subject s1 = new Subject();
        s1.Record();
    }
}