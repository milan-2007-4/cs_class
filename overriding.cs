using System;
class overriding
{
    public static void Main(String[] args)
    {
        pqr p=new pqr();
        xyz x=new xyz();
        p.method();
        x.method();
    }
}
public class abc
{
    public virtual void method1()
    {
        Console.WriteLine("hello abc");
    }
}
public class pqr : abc
{
    public sealed override void method()
    {
        Console.WriteLine("hello pqr");
    }
}

public class xyz : abc
{
    public override void method()
    {
        Console.WriteLine("hello xyz");
    }
}