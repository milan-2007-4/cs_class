using System;
class j_arrey
{
   public static void Main()
    {
        Console.Write("Enter number of rows=");
        int r = Convert.ToInt32(Console.ReadLine());
        int[][] j_array = new int[r][];
        for (int i = 0; i < r; i++)
        {
            Console.Write("enter number of columns for row " + i + ": ");
            int c = Convert.ToInt32(Console.ReadLine());
            j_array[i] = new int[c];
            for (int j = 0; j < c; j++)
            {
                Console.Write("enter value for [" + i + "][" + j + "]: ");
                j_array[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
		
        Console.WriteLine("\nj_arrey  Array Values:");
        for (int i = 0; i < j_array.Length; i++)
        {
            for (int j = 0; j < j_array[i].Length; j++)
            {
                Console.Write(j_array[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}