using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GenericAirlines
{
    static class Validation
    {
        public static bool Name(string input)
        {
            return Regex.IsMatch(input, @"^[\p{L}]{1,50}$");
        }

        public static bool Password(string input)
        {
            return Regex.IsMatch(input, @"^.{1,50}$");
        }

        public static bool Email(string input)
        {
            return Regex.IsMatch(input, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }

        public static bool License(string input)
        {
            return Regex.IsMatch(input, @"^.{1,20}$");
        }

        public static bool PlaneId(string input)
        {
            return Regex.IsMatch(input, @"^.{1,10}$");
        }

        public static bool PlaneModel(string input)
        {
            return Regex.IsMatch(input, @"^.{1,50}$");
        }

        public static bool IATAcode(string input)
        {
            return Regex.IsMatch(input, @"^[A-Z]{3}$");
        }
    }
}
