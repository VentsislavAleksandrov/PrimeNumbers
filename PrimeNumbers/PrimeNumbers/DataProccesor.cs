using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    public class DataProccesor
    {
        private int k;
        private int p;
		private int counter = 1;
		private int mLength;
        private readonly int[,] matrix;
        private List<int> primeNumbers;

        public DataProccesor(int[,] matrix, List<int> primeNumbers, int mLength)
        {
            this.matrix = matrix;
            this.primeNumbers = primeNumbers;
			this.mLength = mLength;
        }

        public void GetPrimeNumbers()
        {
			primeNumbers.Add(0);
			for (int i = 2; i <= Math.Sqrt(int.MaxValue); i++)
			{
				k = 2;
				p = 1;
				while (k < i)
				{
					if (i % k == 0)
					{
						p = 0;
						break;
					}
					k++;
				}
				if (p == 1)
				{
					primeNumbers.Add(i);
					counter++;
				}
				if (counter == mLength)
				{
					break;
				}
			}
        }

		public void FillMatrix()
        {
			for (int i = 1; i <= mLength - 1; i++)
			{
				matrix[0, i] = primeNumbers[i];
				matrix[i, 0] = primeNumbers[i];
			}

			for (int i = 1; i < mLength; i++)
			{
				for (int j = 1; j < mLength; j++)
				{
					matrix[i, j] = matrix[0, j] * matrix[i, 0];
				}
			}
        }
    }
}
