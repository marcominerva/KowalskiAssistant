﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kowalski.Extensions
{
    internal static class StringExtensions
    {
        public static bool Contains(this string source, string value, StringComparison comparison)
            => source?.IndexOf(value, comparison) >= 0;

        public static bool ContainsIgnoreCase(this IEnumerable<string> list, string value)
            => list?.Contains(value, StringComparer.OrdinalIgnoreCase) ?? false;

        public static bool ContainsIgnoreCase(this string source, string value)
            => source?.Contains(value, StringComparison.OrdinalIgnoreCase) ?? false;

        public static bool EqualsIgnoreCase(this string source, string value)
            => string.Equals(source, value, StringComparison.OrdinalIgnoreCase);

        public static bool StartsWithIgnoreCase(this string source, string value)
            => source?.StartsWith(value, StringComparison.OrdinalIgnoreCase) ?? false;

        public static string ReplaceIgnoreCase(this string input, string pattern, string replacement)
            => Regex.Replace(input, pattern, replacement, RegexOptions.IgnoreCase);
    }
}
