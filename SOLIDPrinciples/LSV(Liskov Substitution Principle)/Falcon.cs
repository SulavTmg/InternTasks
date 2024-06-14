public class Falcon : Bird
{
	public override void Move()
	{
		Fly();
	}

	void Fly()
	{
		Console.WriteLine("Falcon flies");
	}
}