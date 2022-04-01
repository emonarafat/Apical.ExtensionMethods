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
    ///     An object extension method that query if '@this' is valid System.DateTimeOffset.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>true if valid System.DateTimeOffset, false if not.</returns>
    public static bool IsValidDateTimeOffSet(this object @this)
    {
        if (@this == null) return true;

        DateTimeOffset result;
        return DateTimeOffset.TryParse(@this.ToString(), out result);
    }
}