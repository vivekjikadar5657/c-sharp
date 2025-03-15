using System;
class person
{
	public void display()
	{
		Console.WriteLine("called");
		abc();
	}
	public static void abc()
	{
		Console.WriteLine("abc called");
	}
}
class demo
{
	public static void Main(string[] args)
	{
		Console.WriteLine("hii");
		person p1=new person();
		p1.display();
		Console.WriteLine("hello");
	}
}