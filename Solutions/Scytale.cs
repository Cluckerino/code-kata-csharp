using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    /// <summary>
    /// Solution for the scytale Kata
    /// https://www.codewars.com/kata/scytale-encoder-slash-decoder-ancient-spartans-cipher/csharp
    /// </summary>
    public static class Scytale
    {
        /// <summary>
        /// Decodes a coded message using a scytale with the given number of sides.
        /// </summary>
        /// <param name="message">The coded message to decode.</param>
        /// <param name="cylinderSides">Number of sides for the decoder.</param>
        /// <returns>The decoded message.</returns>
        public static string Decode(string message, int cylinderSides)
        {
            //! Example: Message has 21 letters for a 6 cylinder scytale.
            //! Since 21 % 6 = 1 != 0, the message will need ceil(21 / 6) = 4 strips.
            //! Only 21 % 6 = 1 of those strips will be filled with 6 letters, the rest will have 5.

            // Calculate the number of strips.
            // If remainderStrips == 0 all strips are full (i.e. the message divided fully into the cylinder).
            // Otherwise, we need to add 1 since integer division does floor, and we need ceil.
            var noOfStrips = Math.DivRem(message.Length, cylinderSides, out var remainderStrips);
            if (remainderStrips > 0) noOfStrips++;

            // Create jagged arrays for the rows.
            var rows = Enumerable.Repeat(0, cylinderSides)
                .Select(_ => new List<char>())
                .ToList();

            // Iterate throught the message and assign each letter to the appropriate row.
            for (int i = 0; i < message.Length; i++)
                rows[i % cylinderSides].Add(message[i]);

            // Join rows to create the message. Trim the ends.
            return string.Concat(rows.SelectMany(r => r))
                .TrimEnd();
        }

        /// <summary>
        /// Encodes a plain message using a scytale with the given number of sides.
        /// </summary>
        /// <param name="message">The plain message to encode.</param>
        /// <param name="cylinderSides">Number of sides for the encoder.</param>
        /// <returns>The encoded message.</returns>
        public static string Encode(string message, int cylinderSides)
        {
            // See Decode for explanation of counting strips.
            var noOfStrips = Math.DivRem(message.Length, cylinderSides, out var remainderStrips);
            if (remainderStrips > 0)
            {
                noOfStrips++;
                // We also want to pad with spaces here so that it wraps correctly at the bottom row.
                message = message.PadRight(noOfStrips * cylinderSides);
            }

            // Create fixed arrays for the strips.
            var strips = Enumerable.Repeat(0, noOfStrips)
                .Select(_ => new char[cylinderSides])
                .ToList();

            // Iterate throught the message and assign each letter to the appropriate location of each strip.
            for (int i = 0; i < message.Length; i++)
            {
                var rowInd = Math.DivRem(i, noOfStrips, out var stripInd);
                strips[stripInd][rowInd] = message[i];
            }

            // Join rows to create the message. Trim the ends.
            return string.Concat(strips.Select(r => new string(r)))
                .TrimEnd();
        }
    }
}