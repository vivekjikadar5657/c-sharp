using System;

namespace Vivek
{
	public delegate void M_del(int a,int b);
	
	class DELEGATE
	{
		public void sum(int a, int b)
		{
			Console.WriteLine("SUM = "+(a+b));
		}
		
		public void sub(int a, int b)
		{
			Console.WriteLine("SUBSTRACTION = "+(a-b));
		}
		
		public void mul(int a, int b)
		{
			Console.WriteLine("MULTIPICATION = "+(a*b));
		}
	}
	class PROGRAM
	{
		public static void Main()
		{
			DELEGATE obj = new DELEGATE();
			M_del md_obj = new M_del(obj.sum);
			md_obj+= obj.sub;
			md_obj+= obj.mul;
			md_obj(60,20);
			Console.ReadLine();
		}
	}
}
