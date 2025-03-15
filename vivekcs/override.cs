using System;
class person
{
	public void display(int a)
	{
		Console.WriteLine("1st called="+a);
	}
	
}
class vivek:person
{
	public void display(int a)
	{
		Console.WriteLine("hello vivek="+a);
	}
}
class demo
{
	public static void Main()
	{
		//vivek v1=new vivek();
		//v1.display();
		person v1=new person();
		v1.display(10);
		
	}
}