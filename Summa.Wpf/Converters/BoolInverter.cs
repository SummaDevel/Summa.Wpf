using System;
using System.Globalization;
using System.Windows.Data;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a bool inverter converter.
    /// </summary>
    public class BoolInverter : IValueConverter
    {

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="BoolInverter"/>.
        /// </summary>
        public BoolInverter()
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
                return !((bool)value);
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

            if (value is bool)
            {
                return !((bool)value);
            }

            return null;

        }

        #endregion

    }

}
