using Inheritance;
public class Program
{
    public static void Main()
    {
        CarModel myCar = new CarModel();
        Console.WriteLine(myCar.brand+" "+ myCar.modelName + " is a " + myCar.category);
    }
}