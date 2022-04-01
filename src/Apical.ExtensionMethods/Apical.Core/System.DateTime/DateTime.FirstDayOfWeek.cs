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
    ///     A DateTime extension method that first day of week.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>A DateTime.</returns>
    public static DateTime FirstDayOfWeek(this DateTime @this)
    {
        return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(-(int)@this.DayOfWeek);
    }
}