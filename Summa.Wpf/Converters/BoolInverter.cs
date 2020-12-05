﻿using System;
using System.Globalization;
using System.Windows;
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

        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is bool boolean)
            {
                return !boolean;
            }

            return DependencyProperty.UnsetValue;

        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is bool boolean)
            {
                return !(boolean);
            }

            return DependencyProperty.UnsetValue;

        }

        #endregion

    }

}
