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
    ///     Returns a value indicating the sign of a double-precision floating-point number.
    /// </summary>
    /// <param name="value">A signed number.</param>
    /// <returns>The <see cref="int" />.</returns>
    public static int Sign(this double value)
    {
        return Math.Sign(value);
    }
}