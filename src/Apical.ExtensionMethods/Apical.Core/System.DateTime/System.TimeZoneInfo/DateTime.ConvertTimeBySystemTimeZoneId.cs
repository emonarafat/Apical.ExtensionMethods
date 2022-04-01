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
    ///     Converts a time to the time in another time zone based on the time zone&#39;s identifier.
    /// </summary>
    /// <param name="dateTime">The date and time to convert.</param>
    /// <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
    /// <returns>The date and time in the destination time zone.</returns>
    public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime, string destinationTimeZoneId)
    {
        return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, destinationTimeZoneId);
    }

    /// <summary>
    ///     Converts a time from one time zone to another based on time zone identifiers.
    /// </summary>
    /// <param name="dateTime">The date and time to convert.</param>
    /// <param name="sourceTimeZoneId">The identifier of the source time zone.</param>
    /// <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
    /// <returns>The <see cref="DateTime" />.</returns>
    public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime, string sourceTimeZoneId,
        string destinationTimeZoneId)
    {
        return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, sourceTimeZoneId, destinationTimeZoneId);
    }
}