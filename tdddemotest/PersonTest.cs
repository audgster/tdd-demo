using NUnit.Framework;
using tdddemo;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var person = new Person();
            person.FirstName = "MyFirstName";
            person.LastName = "MyLastName";

            // Act
            var formattedName = person.getFormattedName();

            // Assert
            Assert.AreEqual("MyFirstName MyLastName", formattedName);
        }
    }
}