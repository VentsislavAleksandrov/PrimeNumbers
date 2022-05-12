using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
			var mLength = n + 1;
            var matrix = new int[mLength, mLength];
			var primeNumbersList = new List<int>();

            var dataProccesor = new DataProccesor(matrix, primeNumbersList, mLength);
            var writer = new Writer();

            dataProccesor.GetPrimeNumbers();
            dataProccesor.FillMatrix();

            writer.WriteToFile(matrix);
            writer.WriteToConsole(matrix, mLength);
		}
    }
}
