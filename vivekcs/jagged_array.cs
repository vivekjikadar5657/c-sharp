using System;
namespace practical
{
	class jagged
	{	
		public static void Main()
		{
			int [][]ja = new int[2][];
			ja[0] = new int[3];
			ja[1] = new int[4];
			
			Console.WriteLine(ja.GetLength(0));
			/*for(int i=0; i<ja.Length; i++)
			{
				Console.WriteLine(ja[i]);
			}*/
		}
	}
}