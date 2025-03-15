class nonpro
{
	static void check()
	{
		System.out.println("Non static");
	}
	public static void main(String[] args)
	{
		pro obj=new pro();
		obj.check();
		System.out.println("my first java program");
	}
}