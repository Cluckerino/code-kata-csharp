using NUnit.Framework;
using Solutions;

namespace Tests
{
    /// <summary>
    /// Test the setup.
    /// </summary>
    [TestFixture]
    public class HelloWorldTest
    {
        [TestCase]
        public void Greet_SaysHello()
        {
            // Arrange
            var hello = new HelloWorld();

            // Act
            var actual = hello.Greet();
            const string expected = "Hello World!";

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}