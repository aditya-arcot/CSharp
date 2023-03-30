using System;

class Program {
	static void Main(string[] args) {
		
		// Console - type that represents console window
		// WriteLine - method
		Console.WriteLine("test");


		string str = "Hello";
		Console.WriteLine(str + " world"); // string building
		Console.WriteLine(str + '!'); // char is single quoted
		Console.WriteLine($"{str} world!"); // string interpolation
		Console.WriteLine($"length: {str.Length}"); // property


		// trim methods
		str = "   abc   ";
		Console.WriteLine($"_{str}_");
		Console.WriteLine($"_{str.TrimStart()}_");
		Console.WriteLine($"_{str.TrimEnd()}_");
		Console.WriteLine($"_{str.Trim()}_");
		
		
		// replace method
		str = "original string";
		Console.WriteLine(str.Replace("i", "z"));


		// upper, lower methods
		str = "xYz";
		Console.WriteLine(str.ToUpper());
		Console.WriteLine(str.ToLower());

		
		// searching - returns boolean
		str = "in the morning";
		Console.WriteLine(str.Contains("morning"));
		Console.WriteLine(str.Contains("evening"));

		Console.WriteLine(str.StartsWith("in"));
		Console.WriteLine(str.EndsWith("in"));
	}
}

