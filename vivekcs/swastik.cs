using System;
namespace VIVEK
{
	class Swastik
	{
		public static void Main()
		{
			Console.WriteLine("Enter Number of * you want = ");
			int a = Convert.ToInt32(Console.ReadLine());
			if(a%2==0)
			{
				a++;
				Console.WriteLine("Sorry,But it is even number so we convert it into a odd number for better Results.");
				Console.WriteLine(a);
			}
			double mid = a/2;
			Console.WriteLine("mid = "+mid);
			mid++;
			for(int i = 1; i <= a; i++)
			{
				for(int j = 1; j <= a; j++)
				{
					if((i==mid||j==mid)||
						(i==1 && j>=mid && j<=a) || 
						(i==a && j<=mid && j<=a) ||
						(j==1 && i>=1 && i<=mid) ||
						(j==a && i>=mid && i<=a)
						)
					{
						Console.Write("* ");
					}
					else
					{
						Console.Write("  ");
					}
				}
				Console.WriteLine();
			}   
		}  
	}  
}