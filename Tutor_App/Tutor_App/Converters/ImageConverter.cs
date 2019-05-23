using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Tutor_App.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Equals(null))
            {
                return null;
            }

            byte[] bytes = value as byte[];

            return ImageSource.FromStream(() => new MemoryStream(bytes));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
