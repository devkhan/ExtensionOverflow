using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionOverflow
{
    /// <summary>
    /// Decimal Extensions
    /// </summary>
    public static class DecimalExtensions
    {
        #region PercentageOf calculations
        
        /// <summary>
		/// The numbers percentage
        /// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
        /// <returns>The result</returns>
        public static decimal PercentageOf(this decimal number, int percent)
        {
			return (decimal)(number * percent / 100);
        }

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this decimal percent, int number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
        public static decimal PercentageOf(this decimal number, decimal percent)
        {
            return (decimal)(number * percent / 100);
        }

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this decimal percent, decimal number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
        public static decimal PercentageOf(this decimal number, long percent)
        {
			return (decimal)(number * percent / 100);
        }

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this decimal percent, long number)
		{
			return (decimal)(number * percent / 100);
		}

        #endregion
    }
}
