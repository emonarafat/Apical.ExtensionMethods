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
    ///     Converts a Coordinated Universal Time (UTC) to the time in a specified time zone.
    /// </summary>
    /// <param name="dateTime">The Coordinated Universal Time (UTC).</param>
    /// <param name="destinationTimeZone">The time zone to convert  to.</param>
    /// <returns>The <see cref="DateTime" />.</returns>
    public static DateTime ConvertTimeFromUtc(this DateTime dateTime, TimeZoneInfo destinationTimeZone)
    {
        return TimeZoneInfo.ConvertTimeFromUtc(dateTime, destinationTimeZone);
    }
}