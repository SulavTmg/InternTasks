using MethodOverloading;
class Program
{
	public static void Main()
	{
		Addition cal = new Addition();
		cal.add(2, 3);
		cal.add(5.5, 5.4);
		cal.add("Sulav", " Tamang");
	}
}