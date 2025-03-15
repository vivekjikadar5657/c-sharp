using System;
class demo
{
	public void fun(ref int p,ref int q)
	{
		Console.WriteLine("fun{0} {1}",p,q);
		p=13234;
		q=7894;
	}
}
class main_cls
{
	public static void Main()
	{
		int b=143,c=897;
		demo x=new demo();
		Console.WriteLine("after calling"+b+c);
		x.fun(ref b,ref c);
		Console.WriteLine("befor calling"+b);
		Console.WriteLine("befor calling"+c);
		Console.ReadLine();
		
	}
}