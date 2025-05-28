interface IStudent
{
    void Record();
}
interface IFaculty
{
    void Professor();
}
class Course : IFaculty, IStudent
{
    public void Record()
    {
        string name = "ram";
        Console.WriteLine(name);
    }
    public void Professor()
    {
        string profname = "Hari";
        Console.WriteLine(profname);
    }

}
class Program
{
    static void Main()
    {
        IStudent c1 = new Course();
        IFaculty c2 = new Course();
        c1.Record();
        c2.Professor();
    }
}