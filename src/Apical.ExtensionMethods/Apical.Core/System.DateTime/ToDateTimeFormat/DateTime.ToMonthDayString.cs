#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Globalization;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that converts this object to a month day string.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToMonthDayString(this DateTime @this)
    {
        return @this.ToString("m", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to a month day string.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToMonthDayString(this DateTime @this, CultureInfo culture)
    {
        return @this.ToString("m", culture);
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to a month day string.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToMonthDayString(this DateTime @this, string culture)
    {
        return @this.ToString("m", new CultureInfo(culture));
    }
}