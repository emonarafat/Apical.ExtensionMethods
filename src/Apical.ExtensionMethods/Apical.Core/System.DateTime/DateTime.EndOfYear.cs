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
    ///     A DateTime extension method that return a DateTime of the last day of the year with the time set to
    ///     "23:59:59:999". The last moment of the last day of the year.  Use "DateTime2" column type in sql to keep the
    ///     precision.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>A DateTime of the last day of the year with the time set to "23:59:59:999".</returns>
    public static DateTime EndOfYear(this DateTime @this)
    {
        return new DateTime(@this.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
    }
}