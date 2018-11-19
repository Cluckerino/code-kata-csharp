using NUnit.Framework;
using Solutions;

namespace Tests
{
    [TestFixture]
    public class MorseCodeDecoderTest
    {
        /// <summary>
        /// Example from Kata.
        /// </summary>
        [Test]
        public void Decode_RegularString_CorrectResult()
        {
            string input = ".... . -.--   .--- ..- -.. .";
            string expected = "HEY JUDE";

            string actual = MorseCodeDecoder.Decode(input);

            Assert.AreEqual(expected, actual);
        }
    }
}