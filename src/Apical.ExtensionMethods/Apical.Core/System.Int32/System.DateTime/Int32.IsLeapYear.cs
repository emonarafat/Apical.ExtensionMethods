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
    ///     Returns an indication whether the specified year is a leap year.
    /// </summary>
    /// <param name="year">A 4-digit year.</param>
    /// <returns>true if  is a leap year; otherwise, false.</returns>
    public static bool IsLeapYear(this int year)
    {
        return DateTime.IsLeapYear(year);
    }
}