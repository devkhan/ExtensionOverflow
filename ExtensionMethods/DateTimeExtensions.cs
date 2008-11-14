using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionOverflow
{
    /// <summary>
    /// DateTime Extensions
    /// </summary>
    public static class DateTimeExtensions
    {
        #region Elapsed extension

        /// <summary>
        /// Percentages the of.
        /// </summary>
        /// <param name="datetime">The datetime.</param>
        /// <returns></returns>
        public static TimeSpan Elapsed(this DateTime datetime)
        {
            return DateTime.Now - datetime;
        }

        #endregion
    }
}
