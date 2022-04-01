#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that checks if '@this' is equal to another string regardless of it's case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="comparedString">The compared string.</param>
    /// <returns>
    ///     true if it contains all values, otherwise false.
    /// </returns>
    public static bool EqualsIgnoreCase(this string @this, string comparedString)
    {
        return @this.Equals(comparedString, StringComparison.OrdinalIgnoreCase);
    }
}