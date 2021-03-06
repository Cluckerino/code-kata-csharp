using NUnit.Framework;
using Solutions;

namespace Tests
{
    /// <summary>
    /// Test the solution for the Josephus problem.
    /// </summary>
    [TestFixture]
    public class JosephusSurvivorTest
    {
        /// <summary>
        /// Solve the examples from the kata with the given parameters.
        /// </summary>
        /// <param name="n">No. of people.</param>
        /// <param name="k">Steps between elimination.</param>
        /// <param name="expected">Expected survivor.</param>
        [TestCase(7, 3, 4)]
        [TestCase(11, 19, 10)]
        [TestCase(40, 3, 28)]
        [TestCase(14, 2, 13)]
        [TestCase(100, 1, 100)]
        [TestCase(1, 300, 1)]
        [TestCase(2, 300, 1)]
        [TestCase(5, 300, 1)]
        [TestCase(7, 300, 7)]
        [TestCase(300, 300, 265)]
        public void JosSurvivor_KataExamples_CorrectResult(int n, int k, int expected)
        {
            var actual = JosephusSurvivor.JosSurvivor(n, k);
            Assert.AreEqual(expected, actual);
        }
    }
}