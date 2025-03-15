using Syastem;
class uservalueboxing
{

		public static void Main()
		{
			//int obj=10;
			//object a=obj;//boxing(implicit)
			object obj;
			int a=(int)obj;//unboxing(explicit)
			int obj=Convert.ToInt32("value of  x using object="+obj);
			Console.WriteLine("value of a="+a);
			Console.Read();
			
		}
}