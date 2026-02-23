//def 31
using System;
class jagged3
{
    static void Main()
    {
        
        int [][][] j_arrey=new int[3][][];
		j_arrey[0]=new int[3][];
		j_arrey[1]=new int[2][];
		j_arrey[2]=new int[2][];
		
		
		j_arrey[0][0]=new int[1];
		j_arrey[0][1]=new int[2];
		j_arrey[0][2]=new int[2];
		
		j_arrey[1][0]=new int[2];
		j_arrey[1][1]=new int[2];
		
		j_arrey[2][0]=new int[2];
		j_arrey[2][1]=new int[2];
		
		j_arrey[0][0][0]=7; 
		
		j_arrey[0][1][0]=77; 
		j_arrey[0][1][1]=777; 
		
		j_arrey[0][2][0]=74; 
		j_arrey[0][2][1]=75; 
		
		j_arrey[1][0][0]=76; 
		j_arrey[1][0][1]=78; 		
		
		j_arrey[1][1][0]=79; 
		j_arrey[1][1][1]=787; 
	
		j_arrey[2][0][0]=70; 
		j_arrey[2][0][1]=71; 		
		
		j_arrey[2][1][0]=72; 
		j_arrey[2][1][1]=73; 
		
	    Console.WriteLine("="+j_arrey[0].Length);
	    Console.WriteLine("coll 1="+j_arrey[1].Length);
	    Console.WriteLine("coll 2="+j_arrey[2].Length);
	    Console.WriteLine("j_arrey size="+j_arrey.GetLength(0));
	    Console.WriteLine("j_arrey size="+j_arrey.GetLength(1));
		
		Console.WriteLine("j_arrey[1][1][1]="+j_arrey[0][0][0]);
		
		Console.WriteLine("j_arrey[1][1][1]="+j_arrey[0][1][0]);
		Console.WriteLine("j_arrey[1][1][1]="+j_arrey[0][1][1]);
		; 	
		Console.WriteLine("j_arrey[1][1][1]="+j_arrey[1][0][0]);
		Console.WriteLine("j_arrey[1][1][1]="+j_arrey[1][0][1]);
		/*for(int a=0;a<j_arrey.GetLength(0);a++)
		{
			for(int v=0;v<j_arrey[1].Length;v++)
			{ 
				Console.WriteLine("j_arrey["+a+"]["+v+"]="+j_arrey[a][v]);
			}
			
		}*/
		Console.WriteLine("j_arrey[2][0]="+j_arrey[2][0][0]);
	Console.ReadLine();
		
    }
}