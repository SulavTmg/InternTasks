class Program
{
	public static void Main()
	{
		for (int i = 0; i < 8; i++)
		{
			for (int j = i; j < 8; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
		Console.ReadLine();
	}
}