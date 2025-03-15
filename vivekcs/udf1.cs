using System;
class xyz
{
	public int id;
	public string name;
	public void print()
	{
		Console.WriteLine(id);
		Console.WriteLine(name);
	}
	public static void Main()
	{
		xyz x=new xyz();
		xyz y=new xyz();
		x.id=10;
		x.name="vivek";
		y.id=11;
		y.name="mayur";
		x.print();
		y.print();
		Console.WriteLine("hello jikadara");
		Console.ReadLine();
	}
}