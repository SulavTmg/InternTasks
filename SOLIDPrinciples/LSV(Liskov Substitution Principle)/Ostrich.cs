public class Ostrich : Bird
{
	public override void Move()
	{
		Run();
	}

	void Run()
	{
		Console.WriteLine("Ostrich runs");
	}
}

