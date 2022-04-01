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
    ///     A DateTime extension method that query if 'time' is time equal.
    /// </summary>
    /// <param name="time">The time to act on.</param>
    /// <param name="timeToCompare">Date/Time of the time to compare.</param>
    /// <returns>true if time equal, false if not.</returns>
    public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
    {
        return time.TimeOfDay == timeToCompare.TimeOfDay;
    }
}