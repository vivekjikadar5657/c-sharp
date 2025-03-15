class strict
{
	enum Data{bca,bsc,msc};
	public static void main(String[] args)
	{
		Data bca=Data.bca;
		System.out.println(bca);
		Getdepart(bca);
	}
	public static void Getdepart(Data a)
	{
		System.out.println(a);
	}
}