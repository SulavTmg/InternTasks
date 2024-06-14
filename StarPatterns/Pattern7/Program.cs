class Program
{
	public static void Main()
	{
		int n = 8;

		for (int i = 1; i <= n; i++)
		{
			for (int j = 0; j < i; j++)
			{
				Console.Write("*");
			}

			for (int k = n; k > i; k--)
			{
				Console.Write(" ");
			}

			for (int l = i; l <= 9; l++)
			{
				Console.Write("*");

			}

			if (i > 1)
			{
				for (int m = 1; m < (2 * i - 1); m++)
				{
					Console.Write(" ");

				}
			}

			for (int m = n; m >= i; m--)
			{
				Console.Write("*");

			}

			for (int o = n; o > i; o--)
			{
				Console.Write(" ");
			}
			for (int p = 0; p < i; p++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
		Console.ReadLine();

	}
}