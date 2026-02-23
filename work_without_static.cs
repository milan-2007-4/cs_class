using System;
class work_without_static
{
	 public void fun()
	{
		Console.WriteLine("hellow fun");
	}
	static void Main()
	{
		work_without_static obj=new work_without_static();
		obj.fun();
		Console.ReadLine();
	}
}