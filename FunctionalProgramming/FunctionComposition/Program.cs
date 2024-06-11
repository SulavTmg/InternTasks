class Program
{
	public static void Main()
	{
		Func<int,int> AddOne = n => n + 1;
		Func<int,int> DoubbleIt = n => n * 2;
		Func<int,int> AddOneThenDoubble = n => (DoubbleIt(AddOne(n)));

		Console.WriteLine(AddOneThenDoubble(5));
    }
}