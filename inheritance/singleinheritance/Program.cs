class Student
{
    public void record()
    {
        string name;
        int roll;
        name = "ram";
        roll = 10;
        Console.WriteLine($"{name} {roll}");
    }
}
class Course : Student
{
    public void subject()
    {
        Console.WriteLine("Maths");
    }
}
class Program
{
    static void Main()
    {
        Course c = new Course();
        c.subject();
        c.record();
    }
}