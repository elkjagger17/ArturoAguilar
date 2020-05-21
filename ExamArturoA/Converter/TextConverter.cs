using System;
using System.Globalization;
using ExamArturoA.Models.Objetcs;
using Xamarin.Forms;

namespace ExamArturoA.Converter
{
    /// <summary>
    /// Class for the converter
    /// </summary>
	public class TextConverter : IValueConverter
    {
        /// <summary>
        /// Converter function
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.GetType() == typeof(NameDTO))
            {
                var name = (NameDTO)value;
                return string.Format(" {0} {1} {2}", name.Title, name.First, name.Last);
            }

            if(value.GetType() == typeof(LocationDTO))
            {
                var location = (LocationDTO)value;
                return string.Format(" {0} {1} {2} {3}", location.Street.Name, location.City, location.Country, location.Postcode);
            }

            if(value is string)
            {
                if((string)parameter == "email")
                {
                    return string.Format("( {0} )", ((string)value));   
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Converter back
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}
