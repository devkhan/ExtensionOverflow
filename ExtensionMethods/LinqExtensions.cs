using System;
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

        #region ToCSVString

        /// <summary>
        /// Converts the Linq data to a commaseperated string including header.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static string ToCSVString(this System.Linq.IOrderedQueryable data)
        {
            return ToCSVString(data, "; ");
        }

        /// <summary>
        /// Converts the Linq data to a commaseperated string including header.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <returns></returns>
        public static string ToCSVString(this System.Linq.IOrderedQueryable data, string delimiter)
        {
            return ToCSVString(data, delimiter, null);
        }

        /// <summary>
        /// Converts the Linq data to a commaseperated string including header.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="nullvalue">The nullvalue.</param>
        /// <returns></returns>
        public static string ToCSVString(this System.Linq.IOrderedQueryable data, string delimiter, string nullvalue)
        {
            StringBuilder csvdata = new StringBuilder();
            string replaceFrom = delimiter.Trim();
            string replaceDelimiter = ";";
            System.Reflection.PropertyInfo[] headers = data.ElementType.GetProperties();
            switch (replaceFrom) {
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
            if (headers.Length > 0) {
                foreach (var head in headers) {
                    csvdata.Append(head.Name.Replace("_", " ") + delimiter);
                }
                csvdata.Append("\n");
            }
            foreach (var row in data) {
                var fields = row.GetType().GetProperties();
                for (int i = 0; i < fields.Length; i++) {
                    object value = null;
                    try {
                        value = fields[i].GetValue(row, null);
                    } catch { }
                    if (value != null) {
                        csvdata.Append(value.ToString().Replace("\n", " \f").Replace("_", " ").Replace(replaceFrom, replaceDelimiter) + delimiter);
                    } else {
                        csvdata.Append(nullvalue);
                        csvdata.Append(delimiter);
                    }
                }
                csvdata.Append("\n");
            }
            return csvdata.ToString();
        }

        #endregion

        #region ForEach

        /// <summary>
        /// Runs an action against each of the element in the IEnumerable collection.
        /// </summary>
        /// <param name="enum">The source IEnumerable collection.</param>
        /// <param name="act">The action to perform on each element.</param>
        /// <returns>The IEnumerable collection itself, to allow chaining.</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @enum, Action<T> act)
        {
            @enum.ThrowIfArgumentIsNull("@enum");
            act.ThrowIfArgumentIsNull("act");

            // yield return may not be used here due to the fact that
            // ForEach calls are expected to be run immediatly
            foreach (var item in @enum) act(item);

            return @enum;
        }

        /// <summary>
        /// Runs a function against each of the element in the IEnumerable collection.
        /// Discarding any return values.
        /// </summary>
        /// <param name="enum">The source IEnumerable collection.</param>
        /// <param name="func">The function to run on each element.</param>
        /// <returns>The IEnumerable collection itself, unmodified, to allow chaining.</returns>
        /// <remarks>
        /// This is unlike Select because the IEnumerable collection itself is left unmodified
        /// and the return value is the same IEnumerable collection passed in.
        /// </remarks>
        public static IEnumerable<T> ForEach<T, _>(this IEnumerable<T> @enum, Func<T, _> func)
        {
            @enum.ThrowIfArgumentIsNull("@enum");
            func.ThrowIfArgumentIsNull("func");

            // yield return may not be used here due to the fact that
            // ForEach calls are expected to be run immediatly
            foreach (var item in @enum) func(item);

            return @enum;
        }

        #endregion

    }
}
