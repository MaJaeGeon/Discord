using Discord.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Discord.Converter
{
    public class UserStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch(value.ToString())
            {
                case "Online":
                    return "#43B581";
                case "Offline":
                    return "#747F8D";
                case "Idle":
                    return "#FAA61A";
                case "DoNotDisturb":
                    return "#F04747";
                default:
                    return "#2F3136";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
