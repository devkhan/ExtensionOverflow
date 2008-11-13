using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionOverflow
{
    /// <summary>
    /// Double Extensions
    /// </summary>
    public static class DoubleExtensions
    {
        #region PercentageOf calculations
        
        public static decimal PercentageOf(this double number, int percent)
        {
            return (decimal)(number * percent / 100);
        }
        
		public static decimal PercentageOf(this double number, float percent)
        {
			return (decimal)(number * percent / 100);
        }
        
		public static decimal PercentageOf(this double number, double percent)
        {
			return (decimal)(number * percent / 100);
        }

		public static decimal PercentageOf(this double number, long percent)
        {
			return (decimal)(number * percent / 100);
        }

		public static decimal PercentOf(this double percent, int number)
		{
			return (decimal)(number * percent / 100);
		}

		public static decimal PercentOf(this double percent, float number)
		{
			return (decimal)(number * percent / 100);
		}

		public static decimal PercentOf(this double percent, double number)
		{
			return (decimal)(number * percent / 100);
		}

		public static decimal PercentOf(this double percent, long number)
		{
			return (decimal)(number * percent / 100);
		}

        #endregion
    }
}
