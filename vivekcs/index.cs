using System;
class indexer
{
	private string[] val=new string[3];
	public string this[int index]
	{
		get
		{
			return val[index];
		}
		set
		{
			val[index]=value;
		}
	}
}
class main
{
	public static void Main()
	{
		indexer ic=new indexer();
		ic[0]="c";
		ic[1]="c";
		ic[2]="csharp";
		Console.WriteLine("printing value stored in object use as array");
		Console.WriteLine("first value{0}",ic[0]);
		Console.WriteLine("second value{0}",ic[1]);
		Console.WriteLine("third value{0}",ic[2]);		
	}
}