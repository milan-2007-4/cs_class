using System;

class Area
{
    public int length;
    public int breadth;

    public void getdata()
    {
        int A = length * breadth;
        Console.WriteLine("Rectangle Area = " + A);
    }
}

class ha
{
    public static void Main(string[] args)
    {
        Area obj = new Area();
        obj.length = 5;
        obj.breadth = 23;
        obj.getdata();
    }
}


