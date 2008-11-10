using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExtensionOverflow
{
    /// <summary>
    /// String Extentensions
    /// </summary>
    public static class StringExtensions
    {
		/// <summary>
		/// Formats a string with one literal placeholder.
		/// </summary>
		/// <param name="text">The extension text</param>
		/// <param name="arg0">Argument 0</param>
		/// <returns>The formatted string</returns>
        public static string FormatWith(this string text, object arg0)
        {
			return string.Format(CultureInfo.InvariantCulture, text, arg0);
        }

		/// <summary>
		/// Formats a string with two literal placeholders.
		/// </summary>
		/// <param name="text">The extension text</param>
		/// <param name="arg0">Argument 0</param>
		/// <param name="arg1">Argument 1</param>
		/// <returns>The formatted string</returns>
        public static string FormatWith(this string text, object arg0, object arg1)
        {
			return string.Format(CultureInfo.InvariantCulture, text, arg0, arg1);
        }

		/// <summary>
		/// Formats a string with tree literal placeholders.
		/// </summary>
		/// <param name="text">The extension text</param>
		/// <param name="arg0">Argument 0</param>
		/// <param name="arg1">Argument 1</param>
		/// <param name="arg2">Argument 2</param>
		/// <returns>The formatted string</returns>
        public static string FormatWith(this string text, object arg0, object arg1, object arg2)
        {
			return string.Format(CultureInfo.InvariantCulture, text, arg0, arg1, arg2);
        }

		/// <summary>
		/// Formats a string with a list of literal placeholders.
		/// </summary>
		/// <param name="text">The extension text</param>
		/// <param name="args">The argument list</param>
		/// <returns>The formatted string</returns>
        public static string FormatWith(this string text, params object[] args)
        {
			return string.Format(CultureInfo.InvariantCulture, text, args);
        }

		/// <summary>
		/// Formats a string with a list of literal placeholders.
		/// </summary>
		/// <param name="text">The extension text</param>
		/// <param name="provider">The format provider</param>
		/// <param name="args">The argument list</param>
		/// <returns>The formatted string</returns>
        public static string FormatWith(this string text, IFormatProvider provider, params object[] args)
        {
            return string.Format(provider, text, args);
        }
    }
}
