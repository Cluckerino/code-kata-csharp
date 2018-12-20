using System.Linq;

/// <summary>
/// Solution for the tribonacci sequence kata.
/// See https://www.codewars.com/kata/tribonacci-sequence/csharp
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
            return GenericXbonacci(signature, n);
        }
    }
}