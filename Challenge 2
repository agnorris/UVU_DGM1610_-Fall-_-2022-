Fix the Errors

Original
using System

public class Program
{
	public void Main(
		{
		Console.WriteLine"Welcome);
		DoMath (10,4);
		DoMath (20,7)
		DoMath (30,15);
		
		public void DoMath (int value, int value2){
			var number = value + valu;
			Console.WriteLine(number)
		}
}

Fixed
using System;

public class Program
{
	public void Main()
		{
		Console.WriteLine("Welcome");
		DoMath (10,4);
		DoMath (20,7);
		DoMath (30,15);
	}
		public void DoMath (int value, int value2){
			var number = value + value2;
			Console.WriteLine(number);
		}
}

If Else statement code

using System;
					
public class Program
{
	public Hero heroOne;
	public PowerUp mushroom;
	public PowerUp candy;
	public PowerUp cheese;	
	
	public void Main()
	{
		mushroom = new PowerUp();
		candy = new PowerUp();
		cheese = new PowerUp();
		
		heroOne = new Hero();
		
		heroOne.health = 3;
		heroOne.attack = 3;	
		
		mushroom.health = 1;
		mushroom.attack = -1;
		candy.health = -2;
		candy.attack = 4;
		cheese.health = 3;
		cheese.attack = -1;
					
		Console.WriteLine("Choose Your Powerup");
		EatPowerUp(mushroom.health, mushroom.attack);
		EatPowerUp(candy.health, candy.attack);
		EatPowerUp(cheese.health, cheese.attack);
	}
	public void EatPowerUp (int health, int attack)
	{
		var newhealth = heroOne.health + health; 
		var newattack = heroOne.attack + attack;
		if (newhealth > heroOne.health){
			Console.WriteLine("Health increased");
		}
		else{
			Console.WriteLine("Health decreased");
		}
		if (newattack > heroOne.attack){
			Console.WriteLine("Attack increased");
		}
		else{
			Console.WriteLine("Attack decreased");
		}
	}
	public class Hero
	{
		public int health;
		public int attack;
	}
	public class PowerUp
	{
		public int health;
		public int attack;
	}
}
