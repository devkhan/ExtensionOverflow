using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionOverflow
{
    /// <summary>
    /// Long Extensions
    /// </summary>
	public static class LongExtensions
	{
		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
		public static decimal PercentageOf(this long number, int percent)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
		public static decimal PercentageOf(this long number, float percent)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
		public static decimal PercentageOf(this long number, double percent)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
		public static decimal PercentageOf(this long number, decimal percent)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// The numbers percentage
		/// </summary>
		/// <param name="number">The number.</param>
		/// <param name="percent">The percent.</param>
		/// <returns>The result</returns>
		public static decimal PercentageOf(this long number, long percent)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this long percent, int number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this long percent, float number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this long percent, double number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this long percent, decimal number)
		{
			return (decimal)(number * percent / 100);
		}

		/// <summary>
		/// Percentage of the number.
		/// </summary>
		/// <param name="percent">The percent</param>
		/// <param name="number">The Number</param>
		/// <returns>The result</returns>
		public static decimal PercentOf(this long percent, long number)
		{
			return (decimal)(number * percent / 100);
		}
	}
}
