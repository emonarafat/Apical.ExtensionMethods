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
    ///     Rounds a decimal value to the nearest integral value.
    /// </summary>
    /// <param name="d">A decimal number to be rounded.</param>
    /// <returns>The <see cref="decimal" />.</returns>
    public static decimal Round(this decimal d)
    {
        return Math.Round(d);
    }

    /// <summary>
    ///     Rounds a decimal value to a specified number of fractional digits.
    /// </summary>
    /// <param name="d">A decimal number to be rounded.</param>
    /// <param name="decimals">The number of decimal places in the return value.</param>
    /// <returns>The number nearest to  that contains a number of fractional digits equal to .</returns>
    public static decimal Round(this decimal d, int decimals)
    {
        return Math.Round(d, decimals);
    }

    /// <summary>
    ///     Rounds a decimal value to a specified number of fractional digits. A parameter specifies how to round the
    ///     value if it is midway between two numbers.
    /// </summary>
    /// <param name="d">A decimal number to be rounded.</param>
    /// <param name="decimals">The number of decimal places in the return value.</param>
    /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
    /// <returns>The <see cref="Decimal" />.</returns>
    public static decimal Round(this decimal d, int decimals, MidpointRounding mode)
    {
        return Math.Round(d, decimals, mode);
    }

    /// <summary>
    ///     Rounds a decimal value to the nearest integer. A parameter specifies how to round the value if it is midway
    ///     between two numbers.
    /// </summary>
    /// <param name="d">A decimal number to be rounded.</param>
    /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
    /// <returns>The <see cref="Decimal" />.</returns>
    public static decimal Round(this decimal d, MidpointRounding mode)
    {
        return Math.Round(d, mode);
    }
}