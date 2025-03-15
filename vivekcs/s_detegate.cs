using System;

namespace Vivek
{
	public delegate void del(int a,int b);
	
	class DELEGATE
	{
		public void sum(int a, int b)
		{
			Console.WriteLine("SUM = "+(a+b));
		}
	}
	class PROGRAM
	{
		public static void Main()
		{
			DELEGATE obj = new DELEGATE();
			del d_obj = new del(obj.sum);
			d_obj(10,20);
			Console.ReadLine();
		}
	}
}
