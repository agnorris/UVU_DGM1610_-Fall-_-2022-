Class Example

using System;

public class ClassExample
{

}

public class ClassWithVariables
{
	public int number = 2;
    public string userName = "Bob";
	public string tagLine = "Say goodbye to the trucks, kids, because tomorrow we are taking back the street.";
}

public class ClassWithFunctions
{
	public static void Main()
    {
    	Console.WriteLine("Running Function");
		Console.WriteLine("Bob");
		Console.WriteLine("Say goodbye to the trucks, kids, because tomorrow we are taking back the street.");
    }
}

Correct the Errors

With Errors:
using Sytem;

public class CorrectTheErrors
{
	public static void Main(string[] args)
	{
		Console.WriteLine ("HW);
						   
}

Fixed:
using System;

public class CorrectTheErrors
{
	public static void Main(string[] args)
	{
		Console.WriteLine ("HW");
	}				   
}

Hello World

using System;

public class HelloWorld
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello World");
	}
}

Hero Classes

using System;

public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Weapon swordOne;
	public Weapon swordTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.strength = 3;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.strength = 4;
		
		swordOne = new Weapon();
		swordTwo = new Weapon();
		
		swordOne.name = "Excalibur";
		swordTwo.name = "Cutlass";
		
		swordOne.strength = 2;
		swordTwo.strength = 1;
		
		Console.WriteLine("Hero One Health");
		Console.WriteLine(heroOne.health);
		Console.WriteLine("Hero One Power");
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine("Hero One Strength");
		Console.WriteLine(heroOne.strength + swordTwo.strength);
		
		Console.WriteLine("Hero Two Health");
		Console.WriteLine(heroTwo.health);
		Console.WriteLine("Hero Two Power");
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine("Hero Two Strength");
		Console.WriteLine(heroTwo.strength + swordOne.strength);
	}
}
public class Hero{
	public int health;
	public int powerLevel;
	public int strength;
}
public class Weapon{
	public string name;
	public int strength;
}

My Class

using System;

public class Program
{
	public Villain villainEvilQueen;
	public Villain villainMaleficent;
	public Villain villainJafar;
	public Villain villainUrsula;
	
	public Weapon scepter;
	public Weapon lamp;
	public Weapon poison;
	public Weapon shell;
	
	public void Main()
	{
		villainEvilQueen = new Villain();
		villainMaleficent = new Villain();
		villainJafar = new Villain();
		villainUrsula = new Villain();
		
		scepter = new Weapon();
		lamp = new Weapon();
		poison = new Weapon();
		shell = new Weapon();
		
		villainEvilQueen.health = 5;
		villainEvilQueen.magicPower = 2;
		villainEvilQueen.evilInfluence = 1;
		
		villainMaleficent.health = 3;
		villainMaleficent.magicPower = 4;
		villainMaleficent.evilInfluence = 2;
		
		villainJafar.health = 5;
		villainJafar.magicPower = 1;
		villainJafar.evilInfluence = 2;
		
		villainUrsula.health = 4;
		villainUrsula.magicPower = 3;
		villainUrsula.evilInfluence = 4;
	
		scepter.magicPower = 2;
		lamp.magicPower = 3; 
		poison.magicPower = 1;
		shell.magicPower = 2;
			
		Console.WriteLine("Evil Queen's Health");
		Console.WriteLine(villainEvilQueen.health);
		Console.WriteLine("Evil Queen's Magic Power");
		Console.WriteLine(villainEvilQueen.magicPower + poison.magicPower);
		Console.WriteLine("Evil Queen's Evil Influence");
		Console.WriteLine(villainEvilQueen.evilInfluence);
		
		Console.WriteLine("Maleficent's Health");
		Console.WriteLine(villainMaleficent.health);
		Console.WriteLine("Maleficent's Magic Power");
		Console.WriteLine(villainMaleficent.magicPower + scepter.magicPower);
		Console.WriteLine("Maleficent's Evil Influence");
		Console.WriteLine(villainMaleficent.evilInfluence);
		
		Console.WriteLine("Jafar's Health");
		Console.WriteLine(villainJafar.health);
		Console.WriteLine("Jafar's Magic Power");
		Console.WriteLine(villainJafar.magicPower + lamp.magicPower);
		Console.WriteLine("Jafar's Evil Influence");
		Console.WriteLine(villainJafar.evilInfluence);		
		
		Console.WriteLine("Ursula's Health");
		Console.WriteLine(villainUrsula.health);
		Console.WriteLine("Ursula's Magic Power");
		Console.WriteLine(villainUrsula.magicPower + shell.magicPower);
		Console.WriteLine("Ursula's Evil Influence");
		Console.WriteLine(villainUrsula.evilInfluence);
	}
}
public class Villain{
	public int health;
	public int magicPower;
	public int evilInfluence;
	public string name;
}
public class Weapon{
	
	public int magicPower;

}
