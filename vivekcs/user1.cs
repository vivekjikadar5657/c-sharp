using System;
class user1
{
		
		public static void Main() 
		{
			char obj=Convert.ToChar32(Console.ReadLine());
			object a=obj;//boxing(implicit)
			//object obj;
			//int a=(int)obj;//unboxing(explicit)
			Console.WriteLine("enter value of int=");
			Console.WriteLine(obj);
			Console.WriteLine("value of a="+a);
			Console.Read();
			
		}
}