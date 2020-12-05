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

        #region Properties

        /// <summary>
        /// Decide whether to convert the visibility value.
        /// </summary>
        public bool Invert { get; set; }

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="BoolToVisibility"/>.
        /// </summary>
        public BoolToVisibility()
        { }

        #endregion

        #region Public methods

        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is bool boolean)
            {

                if (Invert)
                {
                    boolean = !boolean;
                }

                if (boolean)
                {
                    return Visibility.Visible;
                }

                return Visibility.Collapsed;

            }

            return DependencyProperty.UnsetValue;

        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is Visibility visibility)
            {

                switch (visibility)
                {
                    case Visibility.Visible:
                        return Invert ? false : true;
                    case Visibility.Collapsed:
                        return Invert ? true : false;
                    case Visibility.Hidden:
                    default:
                        break;
                }

            }

            return DependencyProperty.UnsetValue;

        }

        #endregion

    }
}
