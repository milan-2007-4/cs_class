using System;
class static_cons
{
	static void Main(String[] args)
	{	
		xyz obj2=new xyz(20);
		xyz obj1=new xyz();
		Console.ReadLine();
	}
}
public class xyz
{
    public xyz()
	{
		Console.WriteLine("hellow normal");
	}

	static xyz()
	{
		Console.WriteLine("hellow ");
	}

	 xyz(int b)
	{
		Console.WriteLine(a+b);
	}
}