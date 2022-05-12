using NUnit.Framework;
using PrimeNumbers;
using System.Collections.Generic;

namespace PrimeNumbersTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPrimeNumbersMethodShoudReturnCorectValues()
        {
            int mLength = 6;
            var matrix = new int[mLength, mLength];
            var primeNumbersList = new List<int>();
            var dataProcessor = new DataProccesor(matrix, primeNumbersList, mLength);

            dataProcessor.GetPrimeNumbers();

            Assert.AreEqual(primeNumbersList[0], 0);
            Assert.AreEqual(primeNumbersList[1], 2);
            Assert.AreEqual(primeNumbersList[2], 3);
            Assert.AreEqual(primeNumbersList[3], 5);
            Assert.AreEqual(primeNumbersList[4], 7);
            Assert.AreEqual(primeNumbersList[5], 11);
        }

        [Test]
        public void FillMatrixMethodShoudFillTheCorectValues()
        {
            int mLength = 3;
            var matrix = new int[mLength, mLength];
            var primeNumbersList = new List<int>() {0, 2, 3};
            var dataProcessor = new DataProccesor(matrix, primeNumbersList, mLength);

            dataProcessor.FillMatrix();
            
            Assert.AreEqual(matrix[0,0], 0);
            Assert.AreEqual(matrix[0,1], 2);
            Assert.AreEqual(matrix[0,2], 3);
            Assert.AreEqual(matrix[1,0], 2);
            Assert.AreEqual(matrix[1,1], 4);
            Assert.AreEqual(matrix[1,2], 6);
            Assert.AreEqual(matrix[2,0], 3);
            Assert.AreEqual(matrix[2,1], 6);
            Assert.AreEqual(matrix[2,2], 9);
           

        }
    }
}