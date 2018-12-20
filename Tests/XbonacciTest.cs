using NUnit.Framework;
using Solutions;

namespace Tests
{
    /// <summary>
    /// Test the solution for the Xbonacci problem.
    /// </summary>
    [TestFixture]
    public class XbonacciTest
    {
        /// <summary>
        /// Solve the examples from the kata.
        /// </summary>
        [Test]
        public void Xbonacci_KataExamples_CorrectResult()
        {
            var variabonacci = new Xbonacci();
            Assert.Multiple(() =>
            {
                var expected = new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
                var actual = variabonacci.GenericXbonacci(new double[] { 0, 1 }, 10);
                Assert.That(actual, Is.EqualTo(expected));

                expected = new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
                actual = variabonacci.GenericXbonacci(new double[] { 1, 1 }, 10);
                Assert.That(actual, Is.EqualTo(expected));

                expected = new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 };
                actual = variabonacci.GenericXbonacci(new double[] { 0, 0, 0, 0, 1 }, 10);
                Assert.That(actual, Is.EqualTo(expected));

                expected = new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 };
                actual = variabonacci.GenericXbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10);
                Assert.That(actual, Is.EqualTo(expected));
            });
        }
    }
}