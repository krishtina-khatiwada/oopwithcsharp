using System.Configuration.Assemblies;

class Student
{
    public void Record()
    {
        string name = "ram";
        int roll = 10;
        int age = 20;
        Console.WriteLine($"{name} {roll} {age}");

    }
}
class Faculty : Student
{
    public void Professor()
    {
        string profname = "Hari";
        int profid = 12;
        Console.WriteLine($"{profname}{profid}");

    }
}
class Course : Faculty
{
    public void Subject()
    {
        string subname = "Computer science";
        Console.WriteLine(subname);
    }
}
class Program
{
    static void Main()
    {
        Course c1 = new Course();
        Faculty f1 = new Faculty();
        f1.Record();
        f1.Professor();
        c1.Record();
        c1.Subject();
        c1.Professor();


    }
}