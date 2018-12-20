using NUnit.Framework;
using Solutions;

namespace Tests
{
    /// <summary>
    /// Test the solution for the Tribonacci problem.
    /// </summary>
    [TestFixture]
    public class TribonacciTest
    {
        /// <summary>
        /// Solve the examples from the kata.
        /// </summary>
        [Test]
        public void Tribonacci_KataExamples_CorrectResult()
        {
            var variabonacci = new Xbonacci();
            Assert.Multiple(() =>
            {
                var expected = new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 };
                var actual = variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10);
                Assert.That(actual, Is.EqualTo(expected));

                expected = new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 };
                actual = variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10);
                Assert.That(actual, Is.EqualTo(expected));

                expected = new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 };
                actual = variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10);
                Assert.That(actual, Is.EqualTo(expected));
            });
        }
    }
}