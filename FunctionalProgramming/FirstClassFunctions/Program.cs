using System;

class Program
{
	static int ApplyOperation(Func<int, int, int> operation, int a, int b)
	{
		return operation(a, b);
	}

	static int Add(int x, int y)
	{
		return x + y;
	}

	static int Multiply(int x, int y)
	{
		return x * y;
	}

	static void Main()
	{
		// Using first-class functions
		int resultAdd = ApplyOperation(Add, 5, 3);          
		int resultMultiply = ApplyOperation(Multiply, 5, 3); 

		Console.WriteLine(resultAdd);         
		Console.WriteLine(resultMultiply);    
	}
}
