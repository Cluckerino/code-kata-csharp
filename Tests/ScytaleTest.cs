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

        /// <summary>
        /// Test encode-to-decode to get back the original plain text.
        /// </summary>
        [Test]
        public void Scytale_EncodeToDecode_GetOriginalMessage()
        {
            var message = "CodeWars Scytale Kata";
            var actual = Scytale.Decode(Scytale.Encode(message, 6), 6);
            Assert.AreEqual(message, actual);
        }

        /// <summary>
        /// Test decode-to-encode to get back the original cipher text.
        /// </summary>
        [Test]
        public void Scytale_DecodeToEncode_GetOriginalMessage()
        {
            var message = "CW t aoaSaK drcla esyet";
            var actual = Scytale.Encode(Scytale.Decode(message, 6), 6);
            Assert.AreEqual(message, actual);
        }

        /// <summary>
        /// Encode-to-decode test from the Kata that failed.
        /// </summary>
        [Test]
        public void Scytale_EncodeToDecode_FailedKataTest()
        {
            var message = "crpUefY qvFWUxfiSdjbhaHijRX rtHMYPMQHuYZoT SXUcMISaSIYokdmm ZdUJCGtm W  ";
            var expected = "crpUefY qvFWUxfiSdjbhaHijRX rtHMYPMQHuYZoT SXUcMISaSIYokdmm ZdUJCGtm W";

            var actual = Scytale.Decode(Scytale.Encode(message, 6), 6);
            Assert.AreEqual(expected, actual);
        }
    }
}