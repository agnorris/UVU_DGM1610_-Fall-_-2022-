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

