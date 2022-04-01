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
    ///     A DateTime extension method that ages the given this.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>An int.</returns>
    public static int Age(this DateTime @this)
    {
        if (DateTime.Today.Month < @this.Month ||
            DateTime.Today.Month == @this.Month &&
            DateTime.Today.Day < @this.Day)
            return DateTime.Today.Year - @this.Year - 1;
        return DateTime.Today.Year - @this.Year;
    }
}