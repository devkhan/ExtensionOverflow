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
        #region ToPercent calculations
        
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this long value, int percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this long value, float percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this long value, double percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this long value, decimal percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this long value, long percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        
        #endregion
    }
}
