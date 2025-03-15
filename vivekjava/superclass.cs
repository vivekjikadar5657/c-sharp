class superclass
{
	private int a=50;
	class suclass
	{
		void show()
		{
			superclass object=new superclass();
			system.out.println(object.a);
		}
	}
}
class pakag
{
	public static void main(string[] args)
	{
		superclass obj=new superclass();
		superclass.subclass suboject=obj.new subclass();
		suboject.show();
	}
}