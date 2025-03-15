using System;
	class program
	{
		static void Main()
		{
			Console.Write("enter a name:");
			string username=Console.ReadLine();
			Console.Write("Enter a value:");
			int uservalue=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n");
			Console.WriteLine("you Entered value:"+uservalue);
			Console.WriteLine("you Entered name:"+username);			
		}
	}