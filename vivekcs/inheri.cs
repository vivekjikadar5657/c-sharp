//Inheritance

using System;

class superclass
{
	public void fun()
	{
		Console.WriteLine("Superclass function called");
	}
}
class subclass
{
	public void fun()
	{
		Console.WriteLine("Subclass function called");
	}
}

class main_class
{
	public static void Main()
	{
		subclass obj = new subclass();
		obj.fun();
	}
}
