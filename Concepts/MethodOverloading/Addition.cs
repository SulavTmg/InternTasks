namespace MethodOverloading
{
	public class Addition
	{
		public void add(int x, int y)
		{
			Console.WriteLine(x + y);
		}

		public void add(double x, double y)
		{
			Console.WriteLine(x + y);
		}

		public void add(String x, String y)
		{
			Console.WriteLine(x + y);
		}
	}
}
