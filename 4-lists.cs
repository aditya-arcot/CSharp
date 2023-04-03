using System;
using System.Collections.Generic;

class Program {
	static void Main(string[] args) {
	
		// creating list
		var names = new List<string> {"bob", "anna", "john"};
		

		// iterating over list
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}

	
		// modifying	
		Console.WriteLine();
		names.Add("maria");
		names.Remove("bob");
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}

		
		// indexing
		// indices start at 0
		Console.WriteLine();
		Console.WriteLine($"names[0] is {names[0]}");


		// counting elements
		Console.WriteLine();
		Console.WriteLine($"{names.Count} total names");

		
		// searching
		// index -1 if not found
		Console.WriteLine();
		var index = names.IndexOf("john");
		Console.WriteLine($"index {index}");
		index = names.IndexOf("bob");
		Console.WriteLine($"index {index}");


		// sorting
		Console.WriteLine();
		names.Sort();
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name}");
		}

		

	}
}


