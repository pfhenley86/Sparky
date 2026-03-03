using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        [TestCase("John", "Doe")]
        [TestCase("Ben", "Spark")]
        public void CombineName_InputFirstAndLastName_ReturnFullName(string firstName, string lastName)
        {
            // Arrange
            var customer = new Customer();

            // Act
            string fullName = customer.GreetAndCombineNames(firstName, lastName);

            // Assert
            Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
        }
    }
}
