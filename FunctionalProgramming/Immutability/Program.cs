using Immutability;

class Program
{
	public static void Main()
	{
		var emp = new Employee("Harry", "Frontend Developer");
		Console.WriteLine(emp);
		var emp2 = emp with { Name = "Sohil" };
        Console.WriteLine(emp2);
    }
}