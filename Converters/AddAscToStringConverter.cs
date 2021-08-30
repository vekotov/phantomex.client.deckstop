﻿using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Phantomex.Client.Desktop.Common;

namespace Phantomex.Client.Desktop.Converters
{
    public class AddAscToStringConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string val)
            {
                return $"{val}/{SortType.Asc}";
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        #endregion
    }
}