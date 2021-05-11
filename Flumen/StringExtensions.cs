using System;
using System.Text.RegularExpressions;

namespace Flumen
{
    /// <summary>
    /// Standard BCL methods for strings wrapped in extension methods.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Wraps <see cref="string.IsNullOrEmpty"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string to test.</param>
        /// <returns>Same as <see cref="string.IsNullOrEmpty"/>.</returns>
        public static bool IsNullOrEmpty(this string? @string) =>
            string.IsNullOrEmpty(@string);

        /// <summary>
        /// Wraps <see cref="string.IsNullOrWhiteSpace"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string to test.</param>
        /// <returns>Same as <see cref="string.IsNullOrWhiteSpace"/>.</returns>
        public static bool IsNullOrWhiteSpace(this string? @string) =>
            string.IsNullOrWhiteSpace(@string);

        /// <summary>
        /// Wraps <see cref="Regex.IsMatch(string, string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern.</param>
        /// <returns>Same as <see cref="Regex.IsMatch(string, string)"/>.</returns>
        public static bool IsMatch(this string @string, string pattern) =>
            Regex.IsMatch(@string, pattern);

        /// <summary>
        /// Wraps <see cref="bool.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="bool.Parse(string)"/>.</returns>
        public static bool ToBoolean(this string @string) => 
            bool.Parse(@string);

        /// <summary>
        /// Wraps <see cref="int.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="int.Parse(string)"/>.</returns>
        public static int ToInt32(this string @string) => 
            int.Parse(@string);

        /// <summary>
        /// Wraps <see cref="long.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="long.Parse(string)"/>.</returns>
        public static long ToInt64(this string @string) => 
            long.Parse(@string);

        /// <summary>
        /// Wraps <see cref="short.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="short.Parse(string)"/>.</returns>
        public static short ToInt16(this string @string) => 
            short.Parse(@string);

        /// <summary>
        /// Wraps <see cref="uint.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="uint.Parse(string)"/>.</returns>
        public static uint ToUInt32(this string @string) => 
            uint.Parse(@string);

        /// <summary>
        /// Wraps <see cref="ulong.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="ulong.Parse(string)"/>.</returns>
        public static ulong ToUInt64(this string @string) => 
            ulong.Parse(@string);

        /// <summary>
        /// Wraps <see cref="ushort.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="ushort.Parse(string)"/>.</returns>
        public static ushort ToUInt16(this string @string) => 
            ushort.Parse(@string);

        /// <summary>
        /// Wraps <see cref="byte.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="byte.Parse(string)"/>.</returns>
        public static byte ToByte(this string @string) => 
            byte.Parse(@string);

        /// <summary>
        /// Wraps <see cref="sbyte.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="sbyte.Parse(string)"/>.</returns>
        public static sbyte ToSByte(this string @string) => 
            sbyte.Parse(@string);

        /// <summary>
        /// Wraps <see cref="double.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="double.Parse(string)"/>.</returns>
        public static double ToDouble(this string @string) => 
            double.Parse(@string);

        /// <summary>
        /// Wraps <see cref="float.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="float.Parse(string)"/>.</returns>
        public static float ToSingle(this string @string) => 
            float.Parse(@string);

        /// <summary>
        /// Wraps <see cref="Guid.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="Guid.Parse(string)"/>.</returns>
        public static Guid ToGuid(this string @string) => 
            Guid.Parse(@string);

        /// <summary>
        /// Wraps <see cref="decimal.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="decimal.Parse(string)"/>.</returns>
        public static decimal ToDecimal(this string @string) => 
            decimal.Parse(@string);

        /// <summary>
        /// Wraps <see cref="TimeSpan.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="TimeSpan.Parse(string)"/>.</returns>
        public static TimeSpan ToTimeSpan(this string @string) => 
            TimeSpan.Parse(@string);

        /// <summary>
        /// Wraps <see cref="DateTime.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="DateTime.Parse(string)"/>.</returns>
        public static DateTime ToDateTime(this string @string) => 
            DateTime.Parse(@string);

        /// <summary>
        /// Wraps <see cref="DateTimeOffset.Parse(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="DateTimeOffset.Parse(string)"/>.</returns>
        public static DateTimeOffset ToDateTimeOffset(this string @string) => 
            DateTimeOffset.Parse(@string);

        #if NETSTANDARD2_1 || NETCORE
        /// <summary>
        /// Wraps <see cref="Enum.Parse&lt;TEnum&gt;(string)"/> for using as extension. 
        /// </summary>
        /// <param name="string">The string containing value to convert.</param>
        /// <returns>Same as <see cref="Enum.Parse&lt;TEnum&gt;(string)"/>.</returns>
        public static TEnum To<TEnum>(this string @string)
            where TEnum : struct, Enum =>
            Enum.Parse<TEnum>(@string);
        #endif
    }
}
