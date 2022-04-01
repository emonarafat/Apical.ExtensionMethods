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
    ///     Returns the angle whose tangent is the specified number.
    /// </summary>
    /// <param name="d">A number representing a tangent.</param>
    /// <returns>The <see cref="double" />.</returns>
    public static double Atan(this double d)
    {
        return Math.Atan(d);
    }
}