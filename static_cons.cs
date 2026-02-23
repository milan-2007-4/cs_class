using System;
class static_cons
{
	static void Main()
	{
		xyz obj1=new xyz();
		xyz obj2=new xyz();
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
}