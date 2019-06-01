using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;


namespace Tutor_App.Converters
{
    public class starConverter :IValueConverter
    {
      

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value==null)
                return null;
            int broj = (int)value;

            switch (broj)
            {
                case 1:
                    return ImageSource.FromFile("onestar.png");
                case 2:
                    return ImageSource.FromFile("twostars.png");
                case 3:
                    return ImageSource.FromFile("threstars.png");
                case 4:
                    return ImageSource.FromFile("fourstars.png");
                case 5:
                    return ImageSource.FromFile("fivestar.png");

                default:
                    return null;
                    
            }            
        }

      

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
