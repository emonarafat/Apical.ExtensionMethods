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
    ///     A DateTime extension method that return a DateTime of the first day of the year with the time set to
    ///     "00:00:00:000". The first moment of the first day of the year.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>A DateTime of the first day of the year with the time set to "00:00:00:000".</returns>
    public static DateTime StartOfYear(this DateTime @this)
    {
        return new DateTime(@this.Year, 1, 1);
    }
}