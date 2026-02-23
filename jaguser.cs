using System;
class jaduser
{
    static void Main()
    {
        int i,j,k;

        Console.Write("row=");
        int r=int.Parse(Console.ReadLine());
        int[][][] j_arrey=new int[r][][];
        for(i=0;i<r;i++)
        {
            Console.Write("coll for row "+i+"=");
            int c=int.Parse(Console.ReadLine());
            j_arrey[i]=new int[c][];
			
            for(j=0;j<c;j++)
            {
                Console.Write("box for row "+i+" coll "+j+"=");
                int b=int.Parse(Console.ReadLine());
                j_arrey[i][j]=new int[b];

                for(k=0;k<b;k++)
                {
                    Console.Write("value["+i+"]["+j+"]["+k+"]=");
                    j_arrey[i][j][k]=int.Parse(Console.ReadLine());
                }
            }
        }
// print velues

        for(i=0;i<j_arrey.Length;i++)
        {
            for(j=0;j<j_arrey[i].Length;j++)
            {
                for(k=0;k<j_arrey[i][j].Length;k++)
                {
                    Console.WriteLine("j_arrey["+i+"]["+j+"]["+k+"]="+j_arrey[i][j][k]);
                }
            }
        }

        Console.ReadLine();
    }
}
