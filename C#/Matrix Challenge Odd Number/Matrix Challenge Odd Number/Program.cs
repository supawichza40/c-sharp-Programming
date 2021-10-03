using System;

namespace Matrix_Challenge_Odd_Number
{
    class Program
    {


        static int[,] matrix =
{
        {1,2,3 },
        {4,5,6 },
        {7,8,9 }
    };

        static void Main(string[] args)
        {
            //odd number print
            Console.WriteLine("Printing Odd number");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]%2 == 1)
                    {
                        Console.Write(matrix[i,j]);
                        
                    }
                }

            }
            Console.WriteLine();
            //print(vertically)
            Console.WriteLine("Printing Vetically");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[j, i]);
                    
                    
                }
            }
            Console.WriteLine();
            //print horizontally()
            Console.WriteLine("Printing Horizontally");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);


                }
            }
            Console.WriteLine();
            //print Diagonally()
            Console.WriteLine("Printing Diagonally");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i,i]);
            }
            Console.WriteLine();
            //print Diagonally reverse()
            Console.WriteLine("Printing Diagonally");
            for (int i = 0,j=2; i < matrix.GetLength(0); i++,j--)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
