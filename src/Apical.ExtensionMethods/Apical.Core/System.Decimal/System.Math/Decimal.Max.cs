#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

using System;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Returns the larger of two decimal numbers.
    /// </summary>
    /// <param name="val1">The first of two decimal numbers to compare.</param>
    /// <param name="val2">The second of two decimal numbers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static decimal Max(this decimal val1, decimal val2)
    {
        return Math.Max(val1, val2);
    }
}