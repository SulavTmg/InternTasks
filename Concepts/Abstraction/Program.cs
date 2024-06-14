using Abstraction;
public class Program
{
    public static void Main()
    {
        Shape rectangle = new Rectangle(12.5, 14.5);
        rectangle.Display();
        Console.WriteLine($"Area : {rectangle.CalculateArea()}");
    }
}