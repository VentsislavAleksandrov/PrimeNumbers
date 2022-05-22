using PrimeNumbers.Contracts;
using System.Collections.Generic;

namespace PrimeNumbers
{
    public class Engine : IEngine
    {
        private  IConsoleReader consoleReader;
        public Engine()
        {
            this.consoleReader = new Reader();
        }
        public void Run()
        {
            var n = consoleReader.Read();
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
