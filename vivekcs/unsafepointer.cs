using System;
class main_cls
{
	public static void Main()
	{
		unsafe
		{
			int *a;
			int b;
			a=&b;
			*a=90;
			Console.WriteLine("value of pointer a={0}",*a);
			Console.WriteLine("value of b={0}",b);
		}
	}
}