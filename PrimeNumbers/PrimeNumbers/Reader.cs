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

        private int ReadNumber()
        {
            Console.Write(ConsoleConstants.Input);
            var IsParsed = int.TryParse(Console.ReadLine(), out int n);

            if (IsParsed && n >= 1)
            {
                return n;
            }
            else
            {
                IsParsed = false;
            }

            while (!IsParsed)
            {
                Console.Write(ConsoleConstants.WrongInput);
                IsParsed = int.TryParse(Console.ReadLine(), out int m);

                if (IsParsed && m >= 1)
                {
                    return m;
                }
                else
                {
                    IsParsed = false;
                }
            }

            return 0;
        }
    }
}
