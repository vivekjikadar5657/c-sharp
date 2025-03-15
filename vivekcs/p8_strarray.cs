using System;

namespace Practical
{
	class StrArray
	{
		public static void Main()
		{
			Console.WriteLine("Decide The Size of String Array = ");
			int size = Convert.ToInt32(Console.ReadLine());
			String[] str = new string[size];
			
			//get strings
			for(int i=0; i<size; i++)
			{
				Console.WriteLine("Enter Any String for String Array[{0}]= ",i);
				str[i] = Console.ReadLine();
			}
				
			//print strings
			Console.Write("Strings =");
			foreach(string i in str)
			{
				Console.Write(i);
 			}
		}
	}
}