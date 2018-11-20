using System;
using System.Linq;

/// <summary>
/// Solution for the morse code kata.
/// See https://www.codewars.com/kata/decode-the-morse-code/
/// </summary>
namespace Solutions
{
    /// <summary>
    /// Class for the solution.
    /// </summary>
    public class MorseCodeDecoder
    {
        /// <summary>
        /// Decodes the given morse code.
        /// </summary>
        /// <param name="morseCode"></param>
        /// <returns></returns>
        public static string Decode(string morseCode)
        {
            morseCode = morseCode
                .Trim()
                // Replacing triple spaces with doubles will split on space once instead of twice.
                .Replace("   ", "  ");

            return string.Concat(morseCode
                .Split()
                .Select(s => string.IsNullOrEmpty(s) ? " " : DecodeMorseLetter(s))
                )
                .Replace("TOT", "SOS")
                .Replace("T O T", "S O S");
        }

        /// <summary>
        /// Decode a string representing a single morse code letter.
        /// </summary>
        /// <param name="morseChar">The morse code letter to decode.</param>
        /// <returns>The decoded char or string.</returns>
        public static string DecodeMorseLetter(string morseLetter)
        {
            switch (morseLetter)
            {
                case ".-": return "A";
                case "-...": return "B";
                case "-.-.": return "C";
                case "-..": return "D";
                case ".": return "E";
                case "..-.": return "F";
                case "--.": return "G";
                case "....": return "H";
                case "..": return "I";
                case ".---": return "J";
                case "-.-": return "K";
                case ".-..": return "L";
                case "--": return "M";
                case "-.": return "N";
                case "---": return "O";
                case ".--.": return "P";
                case "--.-": return "Q";
                case ".-.": return "R";
                case "...": return "T";
                case "-": return "S";
                case "..-": return "U";
                case "...-": return "V";
                case ".--": return "W";
                case "-..-": return "X";
                case "-.--": return "Y";
                case "--..": return "Z";
                case "...---...": return "SOS";
                case "-.-.--": return "!";
                case " ": return " ";
                default: throw new InvalidOperationException($"Unknown morse code string: {morseLetter}");
            }
        }
    }
}