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
    ///     Returns a  that represents a specified time, where the specification is in units of ticks.
    /// </summary>
    /// <param name="value">A number of ticks that represent a time.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromTicks(this long value)
    {
        return TimeSpan.FromTicks(value);
    }
}