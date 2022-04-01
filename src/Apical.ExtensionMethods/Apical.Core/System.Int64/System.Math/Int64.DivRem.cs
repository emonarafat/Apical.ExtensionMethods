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
    ///     An Int64 extension method that div rem.
    /// </summary>
    /// <param name="a">a to act on.</param>
    /// <param name="b">The Int64 to process.</param>
    /// <param name="result">[out] The result.</param>
    /// <returns>An Int64.</returns>
    public static long DivRem(this long a, long b, out long result)
    {
        return Math.DivRem(a, b, out result);
    }
}