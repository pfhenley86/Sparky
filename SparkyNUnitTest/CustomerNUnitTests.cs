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
    public class CustomerNUnitTests
    {
        private Customer customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        [TestCase("Ben", "Spark")]
        public void CombineName_InputFirstAndLastName_ReturnFullName(string firstName, string lastName)
        {
            // Arrange
            

            // Act
            string fullName = customer.GreetAndCombineNames(firstName, lastName);

            // Assert
            //ClassicAssert.AreEqual(fullName, "Hello, Ben Spark");
            Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
            Assert.That(fullName, Does.Contain("ben Spark").IgnoreCase);
            Assert.That(fullName, Does.StartWith("Hello,"));
            Assert.That(fullName, Does.EndWith("Spark"));
            Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));

        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull()
        {
            // Arrange
            

            // Act

            // Assert
            ClassicAssert.IsNull(customer.GreetMessage);
        }
    }
}
