using System;
					
public class Program
{
	public static void Main()
	{
		int i = 0;
		while (i < 5)
		{
			Console.WriteLine("i");
			i++;
		}
	}

	public static void Main()
	{
		int i = 0;
		do
		{
			Console.WriteLine("i");
			i++;
		}
		while (i < 5);
	}
	
	public static void Main()
	{
		for (int i = 0; i <5; i++)
		{
			Console.WriteLine("i");
		}
	}

	public static void Main()
	{
		for (int i = 0; i <10; i=i+2)
		{
			Console.WriteLine("i");
		}
	}

	public static void Main()
	{
		string[] dogs = {"Poodle", "Golden Retriever", "German Shepherd", "Dalmation"};
		foreach (string dog in dogs)
		{
			Console.WriteLine(dog);
		}
	}

	public static void Main()
	{
		string[] dogs = {"Poodle", "Golden Retriever", "German Shepherd", "Dalmation"};
		foreach (string dog in dogs)
		{
			Console.WriteLine(dog);
			Console.WriteLine(dogs.Length);
		}
	}

	public static void Main()
	{
		string[] dogs = {"Poodle", "Golden Retriever", "German Shepherd", "Dalmation"};
		for (int i = 0; i < dogs.Length; i++)
		{
			Console.WriteLine(dogs[i]);
		}
	}

	public static void Main()
	{
		string[] dogs = {"Poodle", "Golden Retriever", "German Shepherd", "Dalmation"};
		foreach (string i in dogs)
		{
			Console.WriteLine(i);
		}
	}

	public static void Main()
	{
		string[] dogs = {"Poodle", "Golden Retriever", "German Shepherd", "Dalmation"};
		int i = 0;
		do
		{
			Console.WriteLine(dogs[i]);
			i++;
		}
		while (i < dogs.Length);
	}
}
