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
    ///     Calculates the integral part of a specified double-precision floating-point number.
    /// </summary>
    /// <param name="d">A number to truncate.</param>
    /// <returns>The <see cref="double" />.</returns>
    public static double Truncate(this double d)
    {
        return Math.Truncate(d);
    }
}