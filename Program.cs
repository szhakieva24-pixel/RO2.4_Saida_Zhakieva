using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Exercise 1:");

		Console.Write("Enter your 1st number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter your 2nd number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		if (num1 > num2)
		{
			Console.WriteLine($"{num1} > {num2}");
		}
		else if (num1 < num2)
		{
			Console.WriteLine($"{num1} < {num2}");
		}
		else
		{
			Console.WriteLine($"{num1} = {num2}");
		}



		Console.WriteLine("\nExercise 2:");

		Console.Write("Enter a number: ");
		int a = Convert.ToInt32(Console.ReadLine());

		if (a > 5 && a < 10)
		{
			Console.WriteLine($"{a} > 5 and {a} < 10");
		}
		else
		{
			Console.WriteLine("Unknown number");
		}



		Console.WriteLine("\nExercise 3:");

		Console.Write("Enter a number: ");
		int b = Convert.ToInt32(Console.ReadLine());

		if (b == 5 || b == 10)
		{
			Console.WriteLine("The number is either 5 or 10");
		}
		else
		{
			Console.WriteLine("Unknown number");
		}



		Console.WriteLine("\nExercise 4:");

		Console.Write("Enter deposit amount: ");
		double c = Convert.ToDouble(Console.ReadLine());

		if (c < 100)
		{
			c += c * 0.05;
		}
		else if (c <= 200)
		{
			c += c * 0.07;
		}
		else
		{
			c += c * 0.1;
		}

		Console.WriteLine($"Deposit amount after interest: {c}");



		Console.WriteLine("\nExercise 5:");

		Console.Write("Enter deposit amount: ");
		double d = Convert.ToDouble(Console.ReadLine());
		double percent = 0;

		if (d < 100)
		{
			d = 0.05;
		}
		else if (d <= 200)
		{
			percent = 0.07;
		}
		else
		{
			percent = 0.1;
		}

		d += d * percent + 15;
		Console.WriteLine($"Deposit amount after interest and bonus: {d}");



		Console.WriteLine("\nExercise 6:");

		Console.Write("Enter operation number: 1.Addition  2.Subtraction  3.Multiplication: ");
		int e = Convert.ToInt32(Console.ReadLine());

		switch (e)
		{
			case 1:
				Console.WriteLine("Addition");
				break;
			case 2:
				Console.WriteLine("Subtraction");
				break;
			case 3:
				Console.WriteLine("Multiplication");
				break;
			default:
				Console.WriteLine("The operation is undefined");
				break;
		}



		Console.WriteLine("\nExercise 7:");

		Console.Write("Enter your 1st number: ");
		int x = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter your 2nd number: ");
		int y = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter operation number: 1.Addition  2.Subtraction  3.Multiplication: ");
		int operation7 = Convert.ToInt32(Console.ReadLine());

		switch (operation7)
		{
			case 1:
				Console.WriteLine($"Result: {x} + {y} = {x + y}");
				break;
			case 2:
				Console.WriteLine($"Result: {x} - {y} = {x - y}");
				break;
			case 3:
				Console.WriteLine($"Result: {x} * {y} = {x * y}");
				break;
			default:
				Console.WriteLine("The operation is undefined");
				break;
		}

		Console.ReadKey();
	}
}