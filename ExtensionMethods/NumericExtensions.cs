using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionOverflow
{
    /// <summary>
    /// Extensions that is general for all numeric types like
    ///     byte, sbyte, short, ushort, int, uint, float, double, decimal, long, ulong
    /// </summary>
    public static class NumericExtensions
    {
        public static int FormatWith(this int value, int arg0)
        {
            return value;
        }
    }
}
