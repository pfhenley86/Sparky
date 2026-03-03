using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            int result = calc.AddNumber(10, 20);

            //Assert
           ClassicAssert.AreEqual(30, result);
        }

        [Test]
        [TestCase(10)]
        [TestCase(22)]
        public void IsOddChecker_InputEvenNumber_ReturnFalse(int a)
        {
            //Arrange
            Calculator calc = new ();

            //Act
            bool isOdd = calc.IsOddNumber(a);

            //Assert
            ClassicAssert.That(isOdd,Is.EqualTo(false));
            ClassicAssert.IsFalse(isOdd);
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool isOdd = calc.IsOddNumber(a);

            //Assert
            ClassicAssert.That(isOdd, Is.EqualTo(true));
            ClassicAssert.IsTrue(isOdd);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(20, ExpectedResult = false)]

        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            //Arrange
            Calculator calc = new();

            //Act && Assert
            return calc.IsOddNumber(a);
        }

        [Test]
        [TestCase(5.4, 10.5)] //15.9
        [TestCase(5.43, 10.53)] // 15.93
        [TestCase(5.49, 10.59)] // 16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //Arrange
            Calculator calc = new();

            //Act
            double result = calc.AddNumberDouble(a, b);

            //Assert
            ClassicAssert.AreEqual(15.9, result,.2);
            //15.7-16.1
        }


    }
}
