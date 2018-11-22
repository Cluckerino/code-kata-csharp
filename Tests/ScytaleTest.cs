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

        /// <summary>
        /// Encode a message that won't fit evenly into the cylinder.
        /// </summary>
        [Test]
        public void Scytale_EncodeUneven()
        {
            var message = "CodeWars Scytale Kata";
            var expected = "CW t aoaSaK drcla esyet";
            var actual = Scytale.Encode(message, 6);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Decode a message that won't fit evDely into the cylinder.
        /// </summary>
        [Test]
        public void Scytale_DecodeUneven()
        {
            var message = "CW t aoaSaK drcla esyet";
            var expected = "CodeWars Scytale Kata";
            var actual = Scytale.Decode(message, 6);
            Assert.AreEqual(expected, actual);
        }
    }
}