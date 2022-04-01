#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that extracts all UInt64 from the string.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>All extracted UInt64.</returns>
    public static ulong[] ExtractManyUInt64(this string @this)
    {
        return Regex.Matches(@this, @"\d+")
            .Cast<Match>()
            .Select(x => Convert.ToUInt64(x.Value))
            .ToArray();
    }
}