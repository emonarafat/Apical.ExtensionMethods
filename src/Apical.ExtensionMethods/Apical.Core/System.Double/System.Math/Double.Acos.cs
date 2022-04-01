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
    ///     Returns the angle whose cosine is the specified number.
    /// </summary>
    /// <param name="d">The d<see cref="double" />.</param>
    /// <returns>An angle, ?, measured in radians, such that 0 ????-or-  if  &lt; -1 or  &gt; 1 or  equals .</returns>
    public static double Acos(this double d)
    {
        return Math.Acos(d);
    }
}