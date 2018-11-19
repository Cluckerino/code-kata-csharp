using NUnit.Framework;
using Solutions;
using System.Collections.Generic;

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

        /// <summary>
        /// Test decoding of single letter.
        /// </summary>
        [Test]
        public void DecodeMorseLetter_SingleLetter_CorrectResult()
        {
            var morseDictionary = new Dictionary<string, char>
            {
                {".-", 'A' },
                {"-...", 'B' },
                {"-.-.", 'C' },
                {"-..", 'D' },
                {".", 'E' },
                {"..-.", 'F' },
                {"--.", 'G' },
                {"....", 'H' },
                {"..", 'I' },
                {".---", 'J' },
                {"-.-", 'K' },
                {".-..", 'L' },
                {"--", 'M' },
                {"-.", 'N' },
                {"---", 'O' },
                {".--.", 'P' },
                {"--.-", 'Q' },
                {".-.", 'R' },
                {"...", 'T' },
                {"-", 'S' },
                {"..-", 'U' },
                {"...-", 'V' },
                {".--", 'W' },
                {"-..-", 'X' },
                {"-.--", 'Y' },
                {"--..", 'Z' },
                {" ", ' ' },
            };

            Assert.Multiple(() =>
            {
                foreach (var entry in morseDictionary)
                {
                    var input = entry.Key;
                    var expected = entry.Value;
                    var actual = MorseCodeDecoder.DecodeMorseLetter(input);
                    Assert.AreEqual(expected, actual);
                }
            });
        }
    }
}