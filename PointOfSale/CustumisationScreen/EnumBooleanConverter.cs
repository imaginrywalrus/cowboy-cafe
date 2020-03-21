/*

* Author: Kendall Price

* Class name: EnumBooleanConverter.cs

* Purpose: Converts an enum into a boolean for data binding

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace CowboyCafe.PointIOfSale.CustumisationScreen
{
    /// <summary>
    /// Converts an enum to boolean for data binding
    /// </summary>
    public class EnumBooleanConverter : IValueConverter
    {
        /// <summary>
        /// Converts an enum to a boolean
        /// </summary>
        /// <param name="value">value from binding</param>
        /// <param name="targetType">the type to convert to</param>
        /// <param name="parameter">converter parameter to use</param>
        /// <param name="culture">culture used in converter</param>
        /// <returns>the converted object</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value?.Equals(parameter);
        }

        /// <summary>
        /// Converts the boolean back to an enum
        /// </summary>
        /// <param name="value">value from binding</param>
        /// <param name="targetType">the type to convert to</param>
        /// <param name="parameter">converter parameter to use</param>
        /// <param name="culture">culture used in converter</param>
        /// <returns>The reverted enum</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value?.Equals(true) == true)?parameter:Binding.DoNothing;
        }
    }
}
