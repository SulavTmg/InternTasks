public class Fan : IDevice
{
	public void SwitchOn()
	{
		Console.WriteLine("Fan switched on.");
	}

	public void SwitchOff()
	{
		Console.WriteLine("Fan switched off.");
	}
}