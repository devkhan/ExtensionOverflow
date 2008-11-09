using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethod
{
    /// <summary>
    /// <see cref="System.String" /> extensions.
    /// </summary>
    public static class StringExtensions
    {

        public static string Formats(this string s, object arg0)
        {
            return string.Format(s, arg0);
        }
        public static string Formats(this string s, object arg0, object arg1)
        {
            return string.Format(s, arg0, arg1);
        }
        public static string Formats(this string s, object arg0, object arg1, object arg2)
        {
            return string.Format(s, arg0, arg1, arg2);
        }
        public static string Formats(this string s, params object[] args)
        {
            return string.Format(s, args);
        }

        public static string Formats(this string s, IFormatProvider provider, params object[] args)
        {
            return string.Format(provider, s, args);
        }


    }
}
