#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Rounds a double-precision floating-point value to the nearest integral value.
    /// </summary>
    /// <param name="a">A double-precision floating-point number to be rounded.</param>
    /// <returns>The <see cref="double" />.</returns>
    public static double Round(this double a)
    {
        return Math.Round(a);
    }

    /// <summary>
    ///     Rounds a double-precision floating-point value to a specified number of fractional digits.
    /// </summary>
    /// <param name="a">A double-precision floating-point number to be rounded.</param>
    /// <param name="digits">The number of fractional digits in the return value.</param>
    /// <returns>The number nearest to  that contains a number of fractional digits equal to .</returns>
    public static double Round(this double a, int digits)
    {
        return Math.Round(a, digits);
    }

    /// <summary>
    ///     Rounds a double-precision floating-point value to a specified number of fractional digits. A parameter
    ///     specifies how to round the value if it is midway between two numbers.
    /// </summary>
    /// <param name="a">A double-precision floating-point number to be rounded.</param>
    /// <param name="digits">The number of fractional digits in the return value.</param>
    /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
    /// <returns>The <see cref="Double" />.</returns>
    public static double Round(this double a, int digits, MidpointRounding mode)
    {
        return Math.Round(a, digits, mode);
    }

    /// <summary>
    ///     Rounds a double-precision floating-point value to the nearest integer. A parameter specifies how to round the
    ///     value if it is midway between two numbers.
    /// </summary>
    /// <param name="a">A double-precision floating-point number to be rounded.</param>
    /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
    /// <returns>The <see cref="Double" />.</returns>
    public static double Round(this double a, MidpointRounding mode)
    {
        return Math.Round(a, mode);
    }
}