using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionOverflow
{
    /// <summary>
    /// Float Extensions
    /// </summary>
    public static class FloatExtensions
    {
        #region ToPercent calculations
        
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this float value, int percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this float value, float percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this float value, double percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }
        /// <summary>
        /// Toes the percent.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="percentOf">The percent of.</param>
        /// <returns></returns>
        public static decimal ToPercent(this float value, long percentOf)
        {
            return (decimal)(value / percentOf * 100);
        }

        #endregion
    }
}
