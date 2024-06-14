class Program
{
	public static void Main()
	{
		for (int i = 1; i <= 8; i++)
		{
			for (int j = i; j <= 16; j++)
			{
				Console.Write(" ");
			}
			for (int k = 0; k < i; k++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
        Console.ReadLine();
    }
}