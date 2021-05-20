using System;

namespace Flumen
{
    /// <summary>
    /// Standard BCL methods from Math and some additional methods wrapped in extension methods.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Wraps <see cref="Math.Sin"/> for using as extension. 
        /// </summary>
        /// <param name="value">Angle.</param>
        public static double Sin(this double value) =>
            Math.Sin(value);

        /// <summary>
        /// Wraps <see cref="Math.Cos"/> for using as extension. 
        /// </summary>
        /// <param name="value">Angle.</param>
        public static double Cos(this double value) =>
            Math.Cos(value);

        /// <summary>
        /// Wraps <see cref="Math.Tan"/> for using as extension. 
        /// </summary>
        /// <param name="value">Angle.</param>
        public static double Tan(this double value) =>
            Math.Tan(value);

        /// <summary>
        /// Calculates cotangent as tan(pi / 2 - value). 
        /// </summary>
        /// <param name="value">Angle.</param>
        public static double Ctan(this double value) => 
            Math.Tan(Math.PI / 2.0 - value);

        /// <summary>
        /// Wraps <see cref="Math.Asin"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number representing sine.</param>
        public static double Asin(this double value) =>
            Math.Asin(value);

        /// <summary>
        /// Wraps <see cref="Math.Acos"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number representing cosine.</param>
        public static double Acos(this double value) =>
            Math.Acos(value);

        /// <summary>
        /// Wraps <see cref="Math.Atan"/> for using as extension. 
        /// </summary>
        /// <param name="value">A number representing tangent.</param>
        public static double Atan(this double value) =>
            Math.Atan(value);

        /// <summary>
        /// Calculates arccotangent as pi / 2 - arctg(a). 
        /// </summary>
        /// <param name="value">A number representing cotangent.</param>
        public static double Actan(this double value) =>
            Math.PI/2 - Math.Atan(value);

        /// <summary>
        /// Wraps <see cref="Math.Abs(double)"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Abs(this double value) =>
            Math.Abs(value);

        /// <summary>
        /// Wraps <see cref="Math.Cbrt"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Cbrt(this double value) =>
            Math.Cbrt(value);

        /// <summary>
        /// Wraps <see cref="Math.Sqrt"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Sqrt(this double value) =>
            Math.Sqrt(value);

        /// <summary>
        /// Wraps <see cref="Math.Exp"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Exp(this double value) =>
            Math.Exp(value);

        /// <summary>
        /// Wraps <see cref="Math.Log(double)"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Log(this double value) =>
            Math.Log(value);

        /// <summary>
        /// Wraps <see cref="Math.Log10"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Log10(this double value) =>
            Math.Log10(value);

        /// <summary>
        /// Wraps <see cref="Math.Floor(double)"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Floor(this double value) =>
            Math.Floor(value);

        /// <summary>
        /// Wraps <see cref="Math.Ceiling(double)"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Ceiling(this double value) =>
            Math.Ceiling(value);

        /// <summary>
        /// Wraps <see cref="Math.Truncate(double)"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Truncate(this double value) =>
            Math.Truncate(value);

        /// <summary>
        /// Wraps <see cref="Math.Round(double)"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Round(this double value) =>
            Math.Round(value);

        /// <summary>
        /// Wraps <see cref="Math.Sign(double)"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        public static double Sign(this double value) =>
            Math.Sign(value);

        /// <summary>
        /// Wraps <see cref="Math.Pow"/> for using as extension. 
        /// </summary>
        /// <param name="value">Double value.</param>
        /// <param name="power">Power.</param>
        public static double Pow(this double value, double power) =>
            Math.Pow(value, power);
    }
}
