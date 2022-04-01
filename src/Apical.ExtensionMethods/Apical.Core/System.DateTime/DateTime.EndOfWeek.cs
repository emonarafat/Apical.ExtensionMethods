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
    ///     A System.DateTime extension method that ends of week.
    /// </summary>
    /// <param name="dt">Date/Time of the dt.</param>
    /// <param name="startDayOfWeek">(Optional) the start day of week.</param>
    /// <returns>A DateTime.</returns>
    public static DateTime EndOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        var end = dt;
        var endDayOfWeek = startDayOfWeek - 1;
        if (endDayOfWeek < 0) endDayOfWeek = DayOfWeek.Saturday;

        if (end.DayOfWeek != endDayOfWeek)
        {
            if (endDayOfWeek < end.DayOfWeek)
                end = end.AddDays(7 - (end.DayOfWeek - endDayOfWeek));
            else
                end = end.AddDays(endDayOfWeek - end.DayOfWeek);
        }

        return new DateTime(end.Year, end.Month, end.Day, 23, 59, 59, 999);
    }
}