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
        #region ToPercent calculations
        
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this decimal value, int percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this decimal value, decimal percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this decimal value, long percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }

        #endregion
    }
}
