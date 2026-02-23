// j_arrey all from instant geted velue
using System;
class jagged
{
    static void Main()
    {
        
        int [][] j_arrey=new int[3][];
		j_arrey[0]=new int[3];
		j_arrey[1]=new int[5];
		j_arrey[2]=new int[1];
		
		j_arrey[0][0]=4;
		j_arrey[0][1]=8;
		j_arrey[0][2]=5;
		
		j_arrey[1][0]=7; 
		j_arrey[1][1]=12;
		j_arrey[1][2]=52;
		j_arrey[1][3]=15;
		j_arrey[1][4]=51;
		
		j_arrey[2][0]=50;
		
	    Console.WriteLine("coll 0="+j_arrey[0].Length);
	    Console.WriteLine("coll 1="+j_arrey[1].Length);
	    Console.WriteLine("coll 2="+j_arrey[2].Length);
	    Console.WriteLine("j_arrey size="+j_arrey.GetLength(0));
	    Console.WriteLine("j_arrey size="+j_arrey.GetLength(1));
		
		Console.WriteLine("j_arrey[1][2]="+j_arrey[1][2]);
		for(int a=0;a<j_arrey.GetLength(0);a++)
		{
			for(int v=0;v<j_arrey[1].Length;v++)
			{
				Console.WriteLine("j_arrey["+a+"]["+v+"]="+j_arrey[a][v]);
			}
			
		}
		Console.WriteLine("j_arrey[2][0]="+j_arrey[2][0]);
	Console.ReadLine();
		
    }
}

