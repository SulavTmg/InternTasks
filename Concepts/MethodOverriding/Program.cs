using Polymorphism;
public class Program
{
	public static void Main()
	{
		Vehicle animal = new Vehicle();
		Bike cat = new Bike();
		Car dog = new Car();
		animal.haveWheels();
		cat.haveWheels();
		dog.haveWheels();
	}
}