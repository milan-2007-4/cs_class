using System;
class twodarrey
{
	public static void Main(string[] args)
	{
		int[,]n=new int[2,3];
		n[0,0]=12;
		n[0,1]=111;
		n[0,2]=121;
		n[1,0]=122;
		n[1,1]=125;
		n[1,2]=128;
		switch 
		 for (int i=0;i<n.GetLength(0);i++)
        {
            for (int j=0;j<n.GetLength(1);j++)
            {
                Console.WriteLine(n[i,j]);
            }
            Console.WriteLine();
		}
	}
}
