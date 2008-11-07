//-------------------------------------------------------------------------------------------------
//
// ClassExtensions.cs - Extension Methods to be used on Classes.
//
// Copyright (c) 2008 C# .net Extension Method Collection Contributers
//
//-------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionsMethods
{
	/// <summary>
	/// Extension Methods to be used be Classes
	/// </summary>
	public static class ClassExtensions
	{
		/// <summary>
		/// Throws an exception if the object called upon is null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj">The This object</param>
		/// <param name="text">The text to be written on the exception</param>
		public static void ThrowIfArgumentIsNull<T>(this T obj, string text) where T : class
		{
			if (obj == null) throw new ArgumentNullException(text + " not allowed to be null");
		}
	}
}
