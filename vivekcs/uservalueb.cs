using Syastem;
class uservalue
{

		public static void Main()
		{
			//int obj=10;
			//object a=obj;//boxing(implicit)
			object obj;
			int a=(int)obj;//unboxing(explicit)
			Console.Write("anter value of int");
			int obj=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(obj);
			Console.WriteLine("value of a="+a);
			Console.Read();
			
		}
}