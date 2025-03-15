using System;
namespace practical
{
	class Array
	{
		public static void Main()
		{
			int row,col;
			
			Console.Write("Decide The Row = ");
			row = Convert.ToInt32(Console.ReadLine());
			int [][]jag = new int[row][];
			
			for(int i=0; i<row; i++)
			{
				Console.Write("Decide the Column of Row [{0}] = ",i);
				col = Convert.ToInt32(Console.ReadLine());
				jag[i] = new int[col];
					
				for(int j=0;j<jag[i].Length; j++)
				{
					Console.Write("Enter Value in Jagged Array = ");
					jag[i][j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			
			Console.WriteLine();
			//for print Jagged Array
			for(int i=0; i<row; i++)
			{
				Console.Write("Row [{0}] =  ",i);
				for(int j=0;j<jag[i].Length; j++)
				{
					Console.Write("{0}   ",jag[i][j]);
				}
				Console.WriteLine();
			}	
			
			int sum = 0;
			for(int i=0; i<row; i++)
			{
				for(int j=0; j<jag[i].Length; j++)
				{					
					sum = sum + jag[i][j];
				}
				
				Console.Write("\nsum of row [{0}] = {1}",i,sum);
				sum = 0;
				//Console.WriteLine();
			}
		}
	}
}
