class Program
{
	public static void Main()
	{

		int n = 7;

		for (int i = 1; i <= n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				Console.Write(" ");
			}

			if (i == 1)
			{
				for (int k = 1; k <= n; k++)
				{
					Console.Write("*");
				}
			}

			if (i > 1 && i<=6)
			{
				Console.Write("*");

				for (int m = 1; m <= 5; m++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
			}

			if (i == n)
			{
				for (int p = 1; p <= 7; p++)
				{
					Console.Write("*");
				}
			}
            Console.WriteLine();
        }

		Console.ReadLine();
	}

}