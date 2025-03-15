import java.util.Scanner;

class array
{
	public static void main(String[] args)
	{
		Scanner var = new Scanner(System.in);
		
		System.out.println("Enter number of Block = ");
		int block = var.nextInt();
		
		System.out.println("Enter number of Row = ");
		int row = var.nextInt();
		
		System.out.println("Enter number of Column =  ");
		int col = var.nextInt();
		
		int ar[][][] = new int[block][row][col];
		
		for(int i=0; i<block; i++)
		{
			for(int j=0; j<row; j++)
			{
				for(int k=0; i<col; k++)
				{
					System.out.println("Enter Value = ");
					int value = var.nextInt();
					array[i][j][k] = value;
				}
			}
		}
		
		for(int i=0; i<array.Length; i++)
		{
			for(int k=0; k<array[i].Length; k++)
			{
				for(int l=0; l<array[i][k]; l++)
				{
					System.out.println(array[i][k][l]);
				}
			}
		}
	}
	
	

}