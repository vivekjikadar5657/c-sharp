using System;
class demo
{
	public virtual void fun()
	{
		Console.WriteLine("fun");
	}
}
class xyz:demo
{
	public override sealed void fun()
	{
		Console.WriteLine("method");
	}
}
class main_cls
{
	public static void Main()
	{
		xyz x=new xyz();
		x.fun();		
		Console.WriteLine("main");
	}
}
	