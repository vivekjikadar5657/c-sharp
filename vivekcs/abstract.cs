using System;
abstract class demo
{
	public void fun()
	{
		Console.WriteLine("fun");
	}
	public abstract void abs_method();
}
class xyz:demo
{
	public override void abs_method()
	{
		Console.WriteLine("abs method");
	}
}
class main_cls
{
	public static void Main()
	{
		xyz x=new xyz();
		x.fun();
		x.abs_method();
		Console.WriteLine("hello MAIN");
	}
}