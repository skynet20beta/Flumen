namespace Flumen
{
    /// <summary>
    /// Standard BCL methods for <see cref="double"/> wrapped in extension methods.
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Wraps <see cref="double.IsNaN"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsNaN"/>.</returns>
        public static bool IsNaN(this double value) =>
            double.IsNaN(value);

        /// <summary>
        /// Wraps <see cref="double.IsInfinity"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsInfinity"/>.</returns>
        public static bool IsInfinity(this double value) =>
            double.IsInfinity(value);

        /// <summary>
        /// Wraps <see cref="double.IsPositiveInfinity"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsPositiveInfinity"/>.</returns>
        public static bool IsPositiveInfinity(this double value) =>
            double.IsPositiveInfinity(value);

        /// <summary>
        /// Wraps <see cref="double.IsNegativeInfinity"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsNegativeInfinity"/>.</returns>
        public static bool IsNegativeInfinity(this double value) =>
            double.IsNegativeInfinity(value);

        /// <summary>
        /// Wraps <see cref="double.IsFinite"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsFinite"/>.</returns>
        public static bool IsFinite(this double value) =>
            double.IsFinite(value);

        /// <summary>
        /// Wraps <see cref="double.IsNormal"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsNormal"/>.</returns>
        public static bool IsNormal(this double value) =>
            double.IsNormal(value);

        /// <summary>
        /// Wraps <see cref="double.IsSubnormal"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsSubnormal"/>.</returns>
        public static bool IsSubnormal(this double value) =>
            double.IsSubnormal(value);

        /// <summary>
        /// Wraps <see cref="double.IsNegative"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsNegative"/>.</returns>
        public static bool IsNegative(this double value) =>
            double.IsNegative(value);

        /// <summary>
        /// Determines whether specified value is positive based on <see cref="double.IsNegative"/>. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <returns>Same as <see cref="double.IsNegative"/>.</returns>
        public static bool IsPositive(this double value) =>
            !double.IsNegative(value);
    }
}
