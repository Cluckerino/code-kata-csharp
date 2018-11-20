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
        /// Tests for failed cases with the SOS strings.
        /// </summary>
        /// <param name="input">The SOS string input.</param>
        /// <param name="expected">The expected variation of SOS.</param>
        [TestCase("...---...", "SOS", TestName = "Decode_SOSCodeSingle_ReturnsSOS")]
        [TestCase("... --- ...", "SOS", TestName = "Decode_SOSCodeLetters_ReturnsSOS")]
        [TestCase("...   ---   ...", "S O S", TestName = "Decode_SOSCodeSpaces_ReturnsSOS")]
        public void Decode_SOSCodeTester(string input, string expected)
        {
            var actual = MorseCodeDecoder.Decode(input);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test decoding of single letter.
        /// </summary>
        [Test]
        public void DecodeMorseLetter_SingleLetter_CorrectResult()
        {
            var morseDictionary = new Dictionary<string, string>
            {
                {".-", "A" },
                {"-...", "B" },
                {"-.-.", "C" },
                {"-..", "D" },
                {".", "E" },
                {"..-.", "F" },
                {"--.", "G" },
                {"....", "H" },
                {"..", "I" },
                {".---", "J" },
                {"-.-", "K" },
                {".-..", "L" },
                {"--", "M" },
                {"-.", "N" },
                {"---", "O" },
                {".--.", "P" },
                {"--.-", "Q" },
                {".-.", "R" },
                {"...", "T" },
                {"-", "S" },
                {"..-", "U" },
                {"...-", "V" },
                {".--", "W" },
                {"-..-", "X" },
                {"-.--", "Y" },
                {"--..", "Z" },
                {"-.-.--", "!"},
                {" ", " "},
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