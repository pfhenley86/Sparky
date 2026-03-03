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
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            //Arrange
            Calculator calc = new ();

            //Act
            bool isOdd = calc.IsOddNumber(10);

            //Assert
            ClassicAssert.That(isOdd,Is.EqualTo(false));
            ClassicAssert.IsFalse(isOdd);
        }

        [Test]
        public void IsOddChecker_InputOddNumber_ReturnTrue()
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool isOdd = calc.IsOddNumber(11);

            //Assert
            ClassicAssert.That(isOdd, Is.EqualTo(true));
            ClassicAssert.IsTrue(isOdd);
        }
    }
}
