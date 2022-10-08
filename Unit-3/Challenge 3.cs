using System;
					
public class Program
{
	public static void Main()
	{
		string[] stats = {"Strength", "Health", "Agility", "Speed", "Attack"};
		foreach (string stat in stats)
			Console.WriteLine(stat);
		string[] attacks = {"Kick", "Punch", "Push"};
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine(attacks[i]);
		}
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		string[] stats = {"Strength", "Health", "Agility", "Speed", "Attack"};
		int i = 0;
		while (i < 5)
		{
			Console.WriteLine("i");
			i++;
		}
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		string[] treats = {"Cupcake", "Brownie", "Cake", "Ice Cream"};
		foreach (string treat in treats)
		{
			Console.WriteLine(treat);
		}
	}
}
