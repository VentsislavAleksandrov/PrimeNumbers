using PrimeNumbers.Constants;
using PrimeNumbers.Contracts;
using System;

namespace PrimeNumbers
{
    public class Reader : IConsoleReader
    {
        public Reader()
        {

        }
        public int Read()
        {
            var num = ReadNumber();

            return num;
        }

        bool IsParsed;
        int n;
        private int ReadNumber()
        {
            Console.Write(ConsoleConstants.Input);
            IsParsed = int.TryParse(Console.ReadLine(), out n);

            if (IsParsed && n >= 1)
            {
                return n;
            }
            else
            {
                ReadNumber();               
            }

            return n;
        }
    }
}
