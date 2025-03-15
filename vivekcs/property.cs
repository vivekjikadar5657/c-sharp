using System;
class demo
{
	private int a;
	public int pr_nm
	{
		set
		{
			a=value;
		}
		get
		{
			return a;
		}
	}
}
class main_cls
{
	public static void Main()
	{
		demo d=new demo();
		d.pr_nm=10;
		Console.WriteLine("value of a in main()= "+d.pr_nm);    
	}
}