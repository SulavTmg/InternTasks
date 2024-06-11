using System.Security.Cryptography.X509Certificates;

class Program
{
	public static int Add(Func<int, int, int> operation, int a, int b)
	{
		return operation(a, b);
	}
	public static void Main()
	{
		int sum = Add((x, y) => x + y, 5, 5);
        Console.WriteLine(sum);
    }
}