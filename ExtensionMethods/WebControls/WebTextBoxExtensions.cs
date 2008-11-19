using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace ExtensionOverflow
{
    /// <summary>
    /// Webcontrol TextBox Extensions
    /// </summary>
    public static class WebTextBoxExtensions
    {
        #region FormValue extension
        /// <summary>
        /// The form value for this textbox.
        /// </summary>
        /// <param name="textbox">The textbox.</param>
        /// <returns></returns>
        public static string FormValue(this TextBox textbox)
        {
            string value = textbox.Page.Request.Form[textbox.UniqueID].ToString();
            if (value == null)
            {
                return textbox.Text;
            }
            else return value;
        }
        #endregion
    }
}
