using System;
class TwoDArray
{
    public static void Main(string[] args)
    {
        int[,] n = new int[2, 3];

        Console.WriteLine("Enter 6 values for 2D array:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                n[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Choose option:");
        Console.WriteLine("1. Without GetLenth()");
        Console.WriteLine("2. With GetLenth()");
        int choice = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Without GetLength():");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(n[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                
                 
                Console.WriteLine("With GetLength():");
                for (int i = 0; i < n.GetLength(0); i++)
                {
                    for (int j = 0; j < n.GetLength(1); j++)
                    {
                        Console.Write(n[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                

          
    }
}
