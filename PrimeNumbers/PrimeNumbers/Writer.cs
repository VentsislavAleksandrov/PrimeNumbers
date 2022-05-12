using System;

namespace PrimeNumbers
{
    public class Writer
    {
        public Writer()
        {            
        }

        public void Write(int[,] matrix, int mLength)
        {
            for (int i = 0; i < mLength; i++)
            {
                for (int j = 0; j < mLength; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
