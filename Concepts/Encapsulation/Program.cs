namespace Encapsulation;
class Program
{
    static void Main()
    {
        // Creating a new Car object
        Car myCar = new Car("Toyota Camry", 2022);

        // Using getter and setter methods
        Console.WriteLine($"Initial Car Model: {myCar.Model}, Year: {myCar.Year}");

        myCar.Model = "Honda Accord";
        myCar.Year = 2020;

        Console.WriteLine($"Updated Car Model: {myCar.Model}, Year: {myCar.Year}");

        // Displaying car information using a method
        myCar.DisplayInfo();
    }
}
