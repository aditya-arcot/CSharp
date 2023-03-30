using System;

class Program {
	static void Main(string[] args) {
	
		int a = 3, b = 10;
		Console.WriteLine(a + b);
		Console.WriteLine(a / b); // integer division
	

		// integer limits
		// exceeding causes overflow or underflow
		Console.WriteLine(int.MinValue);
		Console.WriteLine(int.MaxValue);


		// float - non-integers
		float c = 3, d = 10;
		Console.WriteLine(c / d);
		
		Console.WriteLine(float.MinValue);
		Console.WriteLine(float.MaxValue);


		// double - twice num binary digits as float
		Console.WriteLine(double.MinValue);
		Console.WriteLine(double.MaxValue);


		// decimal - smaller range, greater precision than double
		double e = 1.0, f = 3.0;
		Console.WriteLine(e / f);

		decimal g = 1.0M, h = 3.0M; // M suffix
		Console.WriteLine(g / h);

	}
}


