using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Xamarin_TabbedPage_Sample.Utils
{
    public static class StringValidator
    {
        const string ValidEmailAddressPattern = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$";

        public static bool IsEmailValid(string email)
        {
            var regex = new Regex(ValidEmailAddressPattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}