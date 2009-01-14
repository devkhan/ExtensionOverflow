﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionOverflow
{
    /// <summary>
    /// LinQ  Extentensions
    /// </summary>
    public static class LinqExtensions
    {

        /// <summary>
        /// Toes the CSV string.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static string ToCSVString(this System.Linq.IOrderedQueryable data)
        {
            return ToCSVString(data, "; ");
        }

        /// <summary>
        /// Toes the CSV string.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <returns></returns>
        public static string ToCSVString(this System.Linq.IOrderedQueryable data, string delimiter)
        {
            StringBuilder csvdata = new StringBuilder();
            string replaceFrom = delimiter.Trim();
            string replaceDelimiter = ";";
            System.Reflection.PropertyInfo[] headers = data.ElementType.GetProperties();
            switch (replaceFrom)
	        {
                case ";":
                    replaceDelimiter = ":";
                    break;
                case ",":
                    replaceDelimiter = "¸";
                    break;
                case "\t":
                    replaceDelimiter = "    ";
                    break;
		        default:
                    break;
	        }
            if (headers.Length > 0)
            {
                foreach (var head in headers)
                {
                    csvdata.Append(head.Name.Replace("_", " ") + delimiter);
                }
                csvdata.Append("\n");
            }
            foreach (var row in data)
            {
                var fields = row.GetType().GetProperties();
                for (int i = 0; i < fields.Length; i++)
			    {
                    object value = null;
                    try
                    {
                        value = fields[i].GetValue(row, null);
                    }
                    catch { }
                    if (value != null)
                    {
                        csvdata.Append(value.ToString().Replace("\n", " \f").Replace("_", " ").Replace(replaceFrom, replaceDelimiter) + delimiter);
                    }
                    else csvdata.Append("null" + delimiter);
			    }
                csvdata.Append("\n");
            }
            return csvdata.ToString();
        }
    }
}
