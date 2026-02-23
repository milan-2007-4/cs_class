using System;
class Area
{
	int length;
	int breath;
	void getdata()
	{
		int A=length*breath;
		Console.WriteLine("rectengal Area="+A);   
	}
}
class main 
{
	public static void Main(String[] args)
	{
		Area obj=new Area();
		obj.length=5;
		obj.breath=23;
		obj.getdata();
	}
	
}


