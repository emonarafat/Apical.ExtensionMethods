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
    ///     Returns the cosine of the specified angle.
    /// </summary>
    /// <param name="d">An angle, measured in radians.</param>
    /// <returns>The cosine of . If  is equal to , , or , this method returns .</returns>
    public static double Cos(this double d)
    {
        return Math.Cos(d);
    }
}