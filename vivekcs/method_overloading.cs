using System;
class person
{
	 public void display()
	 {
		Console.WriteLine("1st called");
	 }
	 public void display(int a,double b)
	 {
		Console.WriteLine("3rd called");
	 }
	 public void display(double b,int a,char c)
	 {
		Console.WriteLine("2nd called");
	 }		
}
class demo
{
	public static void Main()
	{
		person v1=new person();
		v1.display();
		v1.display(10,10.10);
		v1.display(66.20,30,'a');
	}
}