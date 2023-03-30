using System;

class Program {
	static void Main(string[] args) {

		// if statement checks value of a bool (true, false)
		// indentation is not required
		int a = 2, b = 3;
		if (a + b > 4)
		{	
			Console.WriteLine("true statement");
		}
		else
		{
			Console.WriteLine("false statement");
		}
	
		
		// other operators: &&, ==, ||

		
		// repeatedly checks condition before running code
		// code can run 0 times
		int count = 2;
		while (count < 5)
		{
			Console.WriteLine($"while: {count}");
			count++;
		}
	
		
		// executes code first, then checks condition
		// code will run at least once
		do
		{
			Console.WriteLine($"do while: {count}");
			count++;
		} while (count < 5);


		// parts - initializer, condition, iterator
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine($"for: {i}");
		}

		
		// forearch will be covered in lists

		

	}
}
