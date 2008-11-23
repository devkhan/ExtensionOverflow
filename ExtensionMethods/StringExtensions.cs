using System;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Diagnostics;

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
			return string.Format(text, arg0);
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
			return string.Format(text, arg0, arg1);
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
			return string.Format(text, arg0, arg1, arg2);
        }

		/// <summary>
		/// Formats a string with a list of literal placeholders.
		/// </summary>
		/// <param name="text">The extension text</param>
		/// <param name="args">The argument list</param>
		/// <returns>The formatted string</returns>
        public static string FormatWith(this string text, params object[] args)
        {
			return string.Format(text, args);
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

		/// <summary>Serialises an object of type T in to an xml string</summary>
		/// <typeparam name="T">Any class type</typeparam>
		/// <param name="objectToSerialise">Object to serialise</param>
		/// <returns>A string that represents Xml, empty oterwise</returns>
		public static string XmlSerialize<T>(this T objectToSerialise) where T : class
		{
			var serialiser = new XmlSerializer(typeof(T));
			string xml;
			using (var memStream = new MemoryStream())
			{
				using (var xmlWriter = new XmlTextWriter(memStream, Encoding.UTF8))
				{
					serialiser.Serialize(xmlWriter, objectToSerialise);
					xml = Encoding.UTF8.GetString(memStream.GetBuffer());
				}
			}
            
            // ascii 60 = '<' and ascii 62 = '>'
			xml = xml.Substring(xml.IndexOf(Convert.ToChar(60)));
			xml = xml.Substring(0, (xml.LastIndexOf(Convert.ToChar(62)) + 1)); 
			return xml;
		}

		/// <summary>Deserialises an xml string in to an object of Type T</summary>
		/// <typeparam name="T">Any class type</typeparam>
		/// <param name="xml">Xml as string to deserialise from</param>
		/// <returns>A new object of type T is successful, null if failed</returns>
		public static T XmlDeserialize<T>(this string xml) where T : class
		{
			var serialiser = new XmlSerializer(typeof(T));
			T newObject;

			using (var stringReader = new StringReader(xml))
			{
				using (var xmlReader = new XmlTextReader(stringReader))
				{
					try
					{
						newObject = serialiser.Deserialize(xmlReader) as T;
					}
					catch (InvalidOperationException) // String passed is not Xml, return null
					{
						return null;
					}

				}
			}

			return newObject;
		}



        #region To X conversions

        /// <summary>
        /// Parses a string into an Enum
        /// </summary>
        /// <typeparam name="T">The type of the Enum</typeparam>
        /// <param name="value">String value to parse</param>
        /// <returns>The Enum corresponding to the stringExtensions</returns>
        public static T ToEnum<T>(this string value)
        {
            return ToEnum<T>(value, false);
        }

        /// <summary>
        /// Parses a string into an Enum
        /// </summary>
        /// <typeparam name="T">The type of the Enum</typeparam>
        /// <param name="value">String value to parse</param>
        /// <param name="ignorecase">Ignore the case of the string being parsed</param>
        /// <returns>The Enum corresponding to the stringExtensions</returns>
        public static T ToEnum<T>(this string value,bool ignorecase)
        {
            if (value == null)
                throw new ArgumentNullException("Value");
            
            value = value.Trim();

            if (value.Length == 0)
                throw new ArgumentNullException("Must specify valid information for parsing in the string.", "value");

            Type t = typeof(T);
            if (!t.IsEnum)
                throw new ArgumentException("Type provided must be an Enum.", "T");

            return (T)Enum.Parse(t, value, ignorecase);
        }
        
        /// <summary>
        /// Toes the integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultvalue">The defaultvalue.</param>
        /// <returns></returns>
        public static int ToInteger(this string value, int defaultvalue)
        {
            return (int)ToDouble(value, 0);
        }
        /// <summary>
        /// Toes the integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static int ToInteger(this string value)
        {
            return ToInteger(value, 0);
        }

        /// <summary>
        /// Toes the double.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultvalue">The defaultvalue.</param>
        /// <returns></returns>
        public static double ToDouble(this string value, double defaultvalue)
        {
            double result;
            if (double.TryParse(value, out result))
            {
                return result;
            } else return defaultvalue;
        }
        /// <summary>
        /// Toes the double.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static double ToDouble(this string value)
        {
            return ToDouble(value, 0);
        }

        /// <summary>
        /// Toes the date time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultvalue">The defaultvalue.</param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this string value, DateTime? defaultvalue)
        {
            DateTime result;
            if (DateTime.TryParse(value, out result))
            {
                return result;
            }
            else return defaultvalue;
        }
        /// <summary>
        /// Toes the date time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this string value)
        {
            return ToDateTime(value, null);
        }

        /// <summary>
        /// Converts a string value to bool value, supports "T" and "F" conversions.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <returns>A bool based on the string value</returns>
        public static bool? ToBoolean(this string value)
        {
            if (string.Compare("T",value,true) == 0)
            {
                return true;
            }
            if (string.Compare("F", value, true) == 0)
            {
                return false;
            }
            bool result;
            if (bool.TryParse(value, out result))
            {
                return result;
            }
            else return null;
        }
        #endregion
    }
}
