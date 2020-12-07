using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a base converter class.
    /// </summary>
    public abstract class ValueConverter : DependencyObject, IValueConverter
    {

        #region Public methods

        /// <inheritdoc/>
        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

    }

}
