using NUnit.Framework;
using Solutions;

namespace Tests
{
    /// <summary>
    /// Scytale test class
    /// </summary>
    [TestFixture]
    public class ScytaleTest
    {
        /// <summary>
        /// Example encode test from Kata.
        /// </summary>
        [Test]
        public void BasicEncodeTest()
        {
            var message = "HELPMEIAMUNDERATTACK";
            var expected = "HENTEIDTLAEAPMRCMUAK";
            var actual = Scytale.Encode(message, 4);

            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// Example decode test from Kata.
        /// </summary>
        [Test]
        public void BasicDecodeTest()
        {
            var message = "HENTEIDTLAEAPMRCMUAK";
            var expected = "HELPMEIAMUNDERATTACK";
            var actual = Scytale.Decode(message, 4);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
