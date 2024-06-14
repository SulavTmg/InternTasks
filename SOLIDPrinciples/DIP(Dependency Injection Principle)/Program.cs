class Progarm
{
	public static void Main()
	{
		IDevice fan = new Fan();
		Switch fanSwitch = new Switch(fan);
		fanSwitch.Operate(true);
		fanSwitch.Operate(false);
	}
}