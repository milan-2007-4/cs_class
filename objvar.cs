using System;
class objvar
{
	static void Main()
	{
		object obj;
		
		obj=10;
		Console.WriteLine("int="+obj);
        obj=25.54;
		Console.WriteLine("doubal="+obj);   
		obj=25.5f;
		Console.WriteLine("float="+obj);
		obj='r';
		Console.WriteLine("string="+obj);
	}
}