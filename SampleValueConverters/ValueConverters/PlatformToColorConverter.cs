﻿using System;
using System.Globalization;
using SampleValueConverters.Enums;
using Xamarin.Forms;

namespace SampleValueConverters.ValueConverters
{
    public class PlatformToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Color.Black;

            if (!Enum.TryParse(value.ToString(), out Platform enumValue))
                return Color.Black;

            switch (enumValue)
            {
                case Platform.Playstation:
                    return Color.Purple;

                case Platform.Wii:
                    return Color.Red;

                case Platform.Xbox:
                    return Color.Green;

                default:
                    return Color.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}