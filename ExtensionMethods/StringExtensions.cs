﻿using System;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Xml.Serialization;
using System.Collections.Generic;

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
    }
}