#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

using System;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Returns the absolute value of a  number.
    /// </summary>
    /// <param name="value">A number that is greater than or equal to , but less than or equal to .</param>
    /// <returns>A decimal number, x, such that 0 ? x ?.</returns>
    public static decimal Abs(this decimal value)
    {
        return Math.Abs(value);
    }
}