class Student
{
    public Student()
    {
        string name = "ram";
        int age = 10;
        Console.WriteLine($"{name} {age}");
    }

}
class Program
{
    static void Main()
    {
        Student s = new Student();
    }
}