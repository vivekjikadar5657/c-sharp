using System;
class boxing
{

		public static void Main()
		{
			//int obj=10;
			//object a=obj;//boxing(implicit)
			object obj=100;
			int a=(int)obj;//unboxing(explicit)
			Console.WriteLine("value of a="+obj);
			Console.WriteLine("value of  x using object="+a);
			Console.Read();
		}
}