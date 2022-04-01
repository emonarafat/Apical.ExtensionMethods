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
    ///     A DateTime extension method that query if 'date' is date equal.
    /// </summary>
    /// <param name="date">The date to act on.</param>
    /// <param name="dateToCompare">Date/Time of the date to compare.</param>
    /// <returns>true if date equal, false if not.</returns>
    public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
    {
        return date.Date == dateToCompare.Date;
    }
}