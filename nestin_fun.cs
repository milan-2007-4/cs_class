//nesting fun in java 
using System;
class nestin_fun
{
	static void Main()
	{
		xyz obj1=new xyz();//xyz
		obj1.show();
		obj1.show();//perent methd
		obj1.display();
		Console.ReadLine();
	}
}
public class abc
{
	public void display()
	{
			Console.WriteLine("this is display");
	}
}
public class xyz:abc
{
	public void show()
	{
		Console.WriteLine("this is show");
		hello();
		display();
	}
	public void hello()
	{
		Console.WriteLine("this is hello");
	}
}