using System;
using System.Collections.Generic;
class two_dublicat
{
    public static void Main(string[] args)
    {
        //row and column size
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, cols];

        //values from the user
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter value for position ["+i+","+j+"]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nThe 2D array is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        // Count dublicat of twodarrey value
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for (int i = 0; i < rows; i++)
        {
            for (int j=0;j<cols;j++)
            {
                int val=array[i,j];
                if (counts.ContainsKey(val))
                {
                    counts[val]++;
                }
                else
                {
                    counts[val]=1;
                }
            }
        }
        //Print duplicates and counts
        bool hasDuplicates = false;
        Console.WriteLine("\nDuplicate values and their counts:");
        foreach (var pair in counts)
        {
            if(pair.Value > 1)
            {
                Console.WriteLine("Value "+pair.Key+" occurs "+pair.Value+" times");
                hasDuplicates = true;
            }
        }

        if(!hasDuplicates)
        {
            Console.WriteLine("No duplicates velue");
        }
    }
}
