using System;
public class student
{
	int id;
	string name;
	public static void Main(string[] args)
	{
		student vivek=new student();
		vivek.id=101;
		vivek.name="jikadara";
		Console.WriteLine(vivek.id);
		Console.WriteLine(vivek.name);
	}
}