using System;

namespace Flumen
{
    /// <summary>
    /// Standard BCL methods for <see cref="TimeSpan"/> wrapped in extension methods.
    /// </summary>
    public static class TimeSpanExtensions
    {
        private const long DAYS_PER_WEEK = 7;

        #region From double

        /// <summary>
        /// Returns a <see cref="TimeSpan"/> that represents a specified number of weeks. 
        /// </summary>
        /// <param name="value">A number of weeks.</param>
        /// <returns><see cref="TimeSpan"/> with a specified number of weeks.</returns>
        public static TimeSpan Week(this double value) =>
            DAYS_PER_WEEK * value.Days();

        /// <summary>
        /// Returns a <see cref="TimeSpan"/> that represents a specified number of weeks. 
        /// </summary>
        /// <param name="value">A number of weeks.</param>
        /// <returns><see cref="TimeSpan"/> with a specified number of weeks.</returns>
        public static TimeSpan Weeks(this double value) =>
            DAYS_PER_WEEK * value.Days();

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromDays"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of days.</param>
        /// <returns>Same as <see cref="TimeSpan.FromDays"/>.</returns>
        public static TimeSpan Day(this double value) =>
            TimeSpan.FromDays(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromDays"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of days.</param>
        /// <returns>Same as <see cref="TimeSpan.FromDays"/>.</returns>
        public static TimeSpan Days(this double value) =>
            TimeSpan.FromDays(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromHours"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of hours.</param>
        /// <returns>Same as <see cref="TimeSpan.FromHours"/>.</returns>
        public static TimeSpan Hour(this double value) =>
            TimeSpan.FromHours(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromHours"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of hours.</param>
        /// <returns>Same as <see cref="TimeSpan.FromHours"/>.</returns>
        public static TimeSpan Hours(this double value) =>
            TimeSpan.FromHours(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromMinutes"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of minutes.</param>
        /// <returns>Same as <see cref="TimeSpan.FromMinutes"/>.</returns>
        public static TimeSpan Minute(this double value) =>
            TimeSpan.FromMinutes(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromMinutes"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of minutes.</param>
        /// <returns>Same as <see cref="TimeSpan.FromMinutes"/>.</returns>
        public static TimeSpan Minutes(this double value) =>
            TimeSpan.FromMinutes(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromSeconds"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of seconds.</param>
        /// <returns>Same as <see cref="TimeSpan.FromSeconds"/>.</returns>
        public static TimeSpan Second(this double value) =>
            TimeSpan.FromSeconds(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromSeconds"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of seconds.</param>
        /// <returns>Same as <see cref="TimeSpan.FromSeconds"/>.</returns>
        public static TimeSpan Seconds(this double value) =>
            TimeSpan.FromSeconds(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromMilliseconds"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>Same as <see cref="TimeSpan.FromMilliseconds"/>.</returns>
        public static TimeSpan Millisecond(this double value) =>
            TimeSpan.FromMilliseconds(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromMilliseconds"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>Same as <see cref="TimeSpan.FromMilliseconds"/>.</returns>
        public static TimeSpan Milliseconds(this double value) =>
            TimeSpan.FromMilliseconds(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromTicks"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of ticks.</param>
        /// <returns>Same as <see cref="TimeSpan.FromTicks"/>.</returns>
        public static TimeSpan Tick(this long value) =>
            TimeSpan.FromTicks(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromTicks"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number of ticks.</param>
        /// <returns>Same as <see cref="TimeSpan.FromTicks"/>.</returns>
        public static TimeSpan Ticks(this long value) =>
            TimeSpan.FromTicks(value);

        #endregion

        #region From int

        /// <summary>
        /// Returns a <see cref="TimeSpan"/> that represents a specified number of weeks. 
        /// </summary>
        /// <param name="value">An integer number of weeks.</param>
        /// <returns><see cref="TimeSpan"/> with a specified number of weeks.</returns>
        public static TimeSpan Week(this int value) =>
            DAYS_PER_WEEK * value.Days();

        /// <summary>
        /// Returns a <see cref="TimeSpan"/> that represents a specified number of weeks. 
        /// </summary>
        /// <param name="value">An integer number of weeks.</param>
        /// <returns><see cref="TimeSpan"/> with a specified number of weeks.</returns>
        public static TimeSpan Weeks(this int value) =>
            DAYS_PER_WEEK * value.Days();

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromDays"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of days.</param>
        /// <returns>Same as <see cref="TimeSpan.FromDays"/>.</returns>
        public static TimeSpan Day(this int value) =>
            TimeSpan.FromDays(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromDays"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of days.</param>
        /// <returns>Same as <see cref="TimeSpan.FromDays"/>.</returns>
        public static TimeSpan Days(this int value) =>
            TimeSpan.FromDays(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromHours"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of hours.</param>
        /// <returns>Same as <see cref="TimeSpan.FromHours"/>.</returns>
        public static TimeSpan Hour(this int value) =>
            TimeSpan.FromHours(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromHours"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of hours.</param>
        /// <returns>Same as <see cref="TimeSpan.FromHours"/>.</returns>
        public static TimeSpan Hours(this int value) =>
            TimeSpan.FromHours(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromMinutes"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of minutes.</param>
        /// <returns>Same as <see cref="TimeSpan.FromMinutes"/>.</returns>
        public static TimeSpan Minute(this int value) =>
            TimeSpan.FromMinutes(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromMinutes"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of minutes.</param>
        /// <returns>Same as <see cref="TimeSpan.FromMinutes"/>.</returns>
        public static TimeSpan Minutes(this int value) =>
            TimeSpan.FromMinutes(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromSeconds"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of seconds.</param>
        /// <returns>Same as <see cref="TimeSpan.FromSeconds"/>.</returns>
        public static TimeSpan Second(this int value) =>
            TimeSpan.FromSeconds(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromSeconds"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of seconds.</param>
        /// <returns>Same as <see cref="TimeSpan.FromSeconds"/>.</returns>
        public static TimeSpan Seconds(this int value) =>
            TimeSpan.FromSeconds(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromMilliseconds"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of milliseconds.</param>
        /// <returns>Same as <see cref="TimeSpan.FromMilliseconds"/>.</returns>
        public static TimeSpan Millisecond(this int value) =>
            TimeSpan.FromMilliseconds(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromMilliseconds"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of milliseconds.</param>
        /// <returns>Same as <see cref="TimeSpan.FromMilliseconds"/>.</returns>
        public static TimeSpan Milliseconds(this int value) =>
            TimeSpan.FromMilliseconds(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromTicks"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of ticks.</param>
        /// <returns>Same as <see cref="TimeSpan.FromTicks"/>.</returns>
        public static TimeSpan Tick(this int value) =>
            TimeSpan.FromTicks(value);

        /// <summary>
        /// Wraps <see cref="TimeSpan.FromTicks"/> for using as extension. 
        /// </summary>
        /// <param name="value">An integer number of ticks.</param>
        /// <returns>Same as <see cref="TimeSpan.FromTicks"/>.</returns>
        public static TimeSpan Ticks(this int value) =>
            TimeSpan.FromTicks(value);

        #endregion
    }
}