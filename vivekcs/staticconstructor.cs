using System;
namespace practical
{
	class Construct
	{
		static int a;
		static Construct(int u)
		//static Construct()
		{
			a = u;
			Console.WriteLine("In Static Constructor");
		}
		void display()
		{
			Console.WriteLine(a);
		}
		
		public static void Main()
		{
			Construct obj = new Construct();
			Construct obj1 = new Construct();
			obj.display();
			obj1.display();
		}
 
	}
}

//Answer = A static Method can't Accept Parameters or Access Modifiers
//This program occurs Error