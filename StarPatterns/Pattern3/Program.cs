class Program
{
	public static void Main()
	{
	
		for (int i = 1; i <= 6; i++)
		{
			for (int j = i; j <= 11; j++)
			{
				Console.Write(" ");
			}

			for (int k = 1; k <= (2 * i - 1); k++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}

		for (int l = 5; l >= 1; l--)
		{

			for (int m = l; m <= 11; m++)
			{
				Console.Write(" ");
			}
			for (int n = 1; n <= (2 * l - 1); n++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}

		Console.ReadLine();

	}
}