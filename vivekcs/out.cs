using System;
class demo
{
	public void fun(out int p,out int q)
	{
		p=13234;
		q=7894;
		Console.WriteLine("fun{0} {1}",p,q);
		
	}
}
class main_cls
{
	public static void Main()
	{
		int b,c;
		demo x=new demo();
		x.fun(out b,out c);
		Console.WriteLine("after calling="+b);
		Console.WriteLine("after calling="+c);
	}
}