public class Switch
{
	private readonly IDevice _device;
	public Switch(IDevice device)
	{
		_device = device;
	}

	public void Operate(bool on)
	{
		if (on)
		{
			_device.SwitchOn();
		}
		else
		{
			_device.SwitchOff();
		}
	}
}
