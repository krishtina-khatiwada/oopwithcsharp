class Student
{
    static int roll;
    static Student()
    {
        roll = 12;
        Console.WriteLine(roll);
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student();
    }
}