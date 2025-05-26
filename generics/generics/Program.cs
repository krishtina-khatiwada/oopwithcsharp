class Cat<T>
{
    public void Meow<T>(T item)
    {
        Console.WriteLine("the cat has a toy" + item);
    }
}
class Program
{
    static void Main()
    {
        Cat<int> c = new Cat<int>();
        c.Meow(12);

    }
}