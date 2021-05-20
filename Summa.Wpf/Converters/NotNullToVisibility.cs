using System;
using System.Globalization;
using System.Windows;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a not <see langword="null"/> visibility converter.
    /// </summary>
    public class NotNullToVisibility : ValueConverter
    {

        #region Public methods

        /// <inheritdoc/>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null)
            {
                return Visibility.Collapsed;
            }

            return Visibility.Visible;

        }

        #endregion

    }

}
