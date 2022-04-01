#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToTitleCase(this string @this)
    {
        return new CultureInfo("en-US").TextInfo.ToTitleCase(@this);
    }

    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cultureInfo">Information describing the culture.</param>
    /// <returns>@this as a string.</returns>
    public static string ToTitleCase(this string @this, CultureInfo cultureInfo)
    {
        return cultureInfo.TextInfo.ToTitleCase(@this);
    }
}