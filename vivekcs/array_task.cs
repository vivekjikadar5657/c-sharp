using System;

namespace array
{
	class array
	{
		public static void Main()
		{
			int [,]ar = new int[2,2];
			
			for(int i=0; i<ar.GetLength(0); i++)
			{
				for(int j=0; j<ar.GetLength(1); j++)
				{
					ar[i,j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			
			for(int i=0; i<ar.GetLength(0); i++)
			{
				for(int j=0; j<ar.GetLength(1); j++)
				{
					Console.WriteLine("a[{0},{1}] = {2}",i,j,ar[i,j]);
				}
			}
			//Console.WriteLine(i);
		}
	}
}