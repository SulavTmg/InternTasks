namespace Singleton;
class Program
{
    public static void Main()
    {
        Singleton singleton1 = Singleton.Instance;
        singleton1.DisplayMessage("Hello from Singleton 1");

        Singleton singleton2 = Singleton.Instance;
        singleton2.DisplayMessage("Hello from Singleton 2");

        if (singleton1 == singleton2)
        {
            Console.WriteLine("Both references point to the same Singleton instance.");
        }
    }
}