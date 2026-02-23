using System;
class sing_inher
{
	static void Main()
	{
		abc obj1=new abc();
		xyz obj2=new xyz();
		obj1.display();
		obj2.show();
		obj2.display();
		Console.ReadLine();
	}
}
public class abc 
{
	public void display()
	{
		Console.WriteLine("this is abc");
	}
}

public class xyz:abc
{
	public void show()
	{
		Console.WriteLine("this is show");
	}
}