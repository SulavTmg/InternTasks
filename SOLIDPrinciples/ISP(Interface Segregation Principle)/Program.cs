class Program
{
	public static void Main()
	{
		IManager manager = new Manager();
		IDeveloper developer = new Developer();
		manager.ManageTeam();
		developer.WriteCode();
	}
}