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
    ///     Returns the base 10 logarithm of a specified number.
    /// </summary>
    /// <param name="d">A number whose logarithm is to be found.</param>
    /// <returns>The <see cref="double" />.</returns>
    public static double Log10(this double d)
    {
        return Math.Log10(d);
    }
}