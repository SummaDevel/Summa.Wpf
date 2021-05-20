using System;
using System.Globalization;
using System.Windows;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a converter which returns the upper invariant of the given string.
    /// </summary>
    public sealed class UpperInvariant : ValueConverter
    {

        #region Public methods

        /// <inheritdoc/>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is string str)
            {
                return str.ToUpperInvariant();
            }

            return DependencyProperty.UnsetValue;

        }

        #endregion

    }

}
