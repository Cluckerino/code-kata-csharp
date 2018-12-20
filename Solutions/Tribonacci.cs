using System.Linq;

/// <summary>
/// Solution Josephus survivor kata.
/// See https://www.codewars.com/kata/josephus-survivor/csharp
/// </summary>
namespace Solutions
{
    /// <summary>
    /// Class for the solution.
    /// </summary>
    public partial class Xbonacci
    {
        /// <summary>
        /// Given the first 3 terms (the signature) of the Tribonacci sequence, extend the sequence
        ///  to the nth term (n includes the signature).
        /// </summary>
        /// <param name="signature">The first 3 terms of the sequence.</param>
        /// <param name="n">The index of the last term, i.e. the length of the output.</param>
        /// <returns>An array containing n terms of the Tribonacci sequence.</returns>
        public double[] Tribonacci(double[] signature, int n)
        {
            var result = signature.ToList();
            var bonacciLength = signature.Length;

            while (result.Count < n)
            {
                var newSum = 0.0;
                for (var i = 0; i < bonacciLength; i++)
                {
                    newSum += result[result.Count - i - 1];
                }
                result.Add(newSum);
            }

            return result.ToArray();
        }
    }
}