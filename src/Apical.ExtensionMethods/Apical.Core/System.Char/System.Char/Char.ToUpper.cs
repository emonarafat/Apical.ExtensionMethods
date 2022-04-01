#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Globalization;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of a Unicode character to its uppercase equivalent.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>The <see cref="char" />.</returns>
    public static char ToUpper(this char c)
    {
        return char.ToUpper(c);
    }

    /// <summary>
    ///     Converts the value of a specified Unicode character to its uppercase equivalent using specified culture-
    ///     specific formatting information.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <param name="culture">An object that supplies culture-specific casing rules.</param>
    /// <returns>The <see cref="char" />.</returns>
    public static char ToUpper(this char c, CultureInfo culture)
    {
        return char.ToUpper(c, culture);
    }
}