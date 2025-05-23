class Student
{
    private int roll;
    private Student()
    {
        roll = 10;
        Console.WriteLine("private constructor called");
    }
    public static Student CreateInstance()
    {
        return new Student();
    }
    public void display()
    {
        Console.WriteLine(roll);
    }
}
class Program
{
    static void Main()
    {
        Student s = Student.CreateInstance();
        s.display();
    }
}