using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Summa.Wpf.Converters
{

    /// <summary>
    /// Defines the <see cref="SolidColorBrush"/> to <see cref="Color"/> converter.
    /// </summary>
    public class SolidBrushToColor : ValueConverter
    {

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="SolidBrushToColor"/>.
        /// </summary>
        public SolidBrushToColor()
        { }

        #endregion

        #region Public methods

        /// <inheritdoc/>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is SolidColorBrush brush)
            {
                return brush.Color;
            }

            return DependencyProperty.UnsetValue;

        }

        /// <inheritdoc/>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is Color color)
            {
                return new SolidColorBrush(color);
            }

            return DependencyProperty.UnsetValue;

        }

        #endregion

    }
}
