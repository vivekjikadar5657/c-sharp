using System;
namespace array
{
	class array
	{
		public static void Main()
		{
			Console.Write("anter value of index=");
			int r=Convert.ToInt32(Console.ReadLine());
			int []ar= new int[r];
			for(int i=0; i<ar.Length; i++)
			{
					Console.Write("enter value=");
					ar[i]=Convert.ToInt32(Console.ReadLine());
				
			}
			
			for(int i=0; i<ar.Length; i++)
			{
				
				
					Console.WriteLine("a[{0}]{1}",i,ar[i]);
				
			}
			//Console.WriteLine(i);
		}
	}
}