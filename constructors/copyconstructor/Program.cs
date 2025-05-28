class Student
{
    public string Name;
    public Student(string name)
    {
        Name = name;
        Console.WriteLine(Name);
    }
    public Student(Student c)
    {
        Name = c.Name;
    }
}
class Program
{
    static void Main()
    {
       Student s = new Student("ram");  
    }
   
}