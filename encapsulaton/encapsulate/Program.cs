class Student
{
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(name = value))
                name = value;
        }
    }
}
class Program
{
    static void Main()
    {
    Student s = new Student();
    s.Name= "Max";
    Console.WriteLine(s.Name);

    }
}