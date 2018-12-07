using System;

/// <summary>
/// Solution Josephus survivor kata.
/// See https://www.codewars.com/kata/josephus-survivor/csharp
/// </summary>
namespace Solutions
{
    /// <summary>
    /// Class for the solution.
    /// </summary>
    public static class JosephusSurvivor
    {
        /// <summary>
        /// Finds the survivor of a Josephus permutation.
        /// </summary>
        /// <param name="n">Initial number of people in the permutation.</param>
        /// <param name="k">Steps until someone is eliminated.</param>
        /// <returns>The position of the survivor.</returns>
        public static int JosSurvivor(int n, int k) => G(n, k) + 1;

        /// <summary>
        /// Zero-indexed version of the above.
        /// </summary>
        /// <param name="n">Initial number of people in the permutation.</param>
        /// <param name="k">Steps until someone is eliminated.</param>
        /// <returns>The zero-based position of the survivor.</returns>
        private static int G(int n, int k)
        {
            if (n == 1) return 0;
            return (G(n - 1, k) + k) % n;
        }
    }
}