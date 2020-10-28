using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a bool to visibility converter.
    /// </summary>
    public class BoolToVisibility : IValueConverter
    {

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="BoolToVisibility"/>.
        /// </summary>
        public BoolToVisibility()
        { }

        #endregion

        #region Public methods

        /// <summary>
        /// Converts the value.
        /// </summary>
        /// <param name="value"> Conversion value. </param>
        /// <param name="targetType"> Binding target type. </param>
        /// <param name="parameter"> Conversion parameter. </param>
        /// <param name="culture"> Conversion culture. </param>
        /// <returns> The converted value, otherwise null. </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is bool)
            {
                if ((bool)value)
                {
                    return Visibility.Visible;
                }

                return Visibility.Collapsed;

            }

            return null;

        }

        /// <summary>
        /// Converts the value back.
        /// </summary>
        /// <param name="value"> Conversion value. </param>
        /// <param name="targetType"> Binding target type. </param>
        /// <param name="parameter"> Conversion parameter. </param>
        /// <param name="culture"> Conversion culture. </param>
        /// <returns> The converted value, otherwise null. </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is Visibility)
            {

                Visibility visibility = (Visibility)value;

                switch (visibility)
                {
                    case Visibility.Visible:
                        return true;
                    case Visibility.Collapsed:
                        return false;
                    default:
                        break;
                }

            }

            return null;

        }

        #endregion

    }
}
