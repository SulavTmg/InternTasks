class Program
{
	public static void Main()
	{
		WaiWaiFactory.getWaiWai(new VegWaiWai());
		WaiWaiFactory.getWaiWai(new ChickenWaiWai());
	}
}