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
    ///     Returns the largest integer less than or equal to the specified double-precision floating-point number.
    /// </summary>
    /// <param name="d">A double-precision floating-point number.</param>
    /// <returns>The largest integer less than or equal to . If  is equal to , , or , that value is returned.</returns>
    public static double Floor(this double d)
    {
        return Math.Floor(d);
    }
}