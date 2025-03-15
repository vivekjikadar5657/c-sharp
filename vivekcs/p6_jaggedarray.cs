using System;
namespace practical
{
	class Array
	{
		
		public static void Main()
		{
			Console.WriteLine("Enter Value of Row = ");
			int row = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter Value of Column = ");
			int col = Convert.ToInt32(Console.ReadLine());
			
			int [][]array = new int[row][col];
			
			for(int i=0; i<row; i++)
			{
				for(int j=0; j<col; j++)
				{
					Console.WriteLine("Enter Value of Array[{0}][{1}]",i,j);
					array[i][j] = Convert.ToInt32(Console.ReadLine());
				}
			}
				
			Console.WriteLine(); //for new line
			for(int i=0; i<row; i++)
			{
				for(int j=0; j<col; j++)
				{
					Console.Write("{0}  ",array[i][j]);
					
				}
				Console.WriteLine();
			}
			int sum=0;
			for(int i=0; i<row; i++)
			{
				for(int j=0; j<col; j++)
				{	
					sum = sum + array[i][j];
					
				}
				Console.Write("\nsum of row = "+sum);
				sum = 0; 	 	
				Console.WriteLine();
			}
		}
	}
}