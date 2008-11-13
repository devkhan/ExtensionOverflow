using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionOverflow
{
    /// <summary>
    /// Integer Extensions
    /// </summary>
    public static class IntExtensions
    {
        #region PercentageOf calculations

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
        public static decimal PercentageOf(this int number, int percent)
        {
			return (decimal)(number * percent / 100);
        }

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this int percent, int number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
        public static decimal PercentageOf(this int number, float percent)
        {
			return (decimal)(number * percent / 100);
        }

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this int percent, float number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
        public static decimal PercentageOf(this int number, double percent)
        {
			return (decimal)(number * percent / 100);
        }

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this int percent, double number)
		{
			return (decimal)(number * percent / 100);
		}

        /// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
		public static decimal PercentageOf(this int number, decimal percent)
        {
			return (decimal)(number * percent / 100);
        }

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this int percent, decimal number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
		public static decimal PercentageOf(this int number, long percent)
        {
			return (decimal)(number * percent / 100);
        }

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this int percent, long number)
		{
			return (decimal)(number * percent / 100);
		}

        #endregion
    }
}
