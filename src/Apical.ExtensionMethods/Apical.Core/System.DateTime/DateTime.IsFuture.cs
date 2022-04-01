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
    ///     A DateTime extension method that query if '@this' is in the future.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>true if the value is in the future, false if not.</returns>
    public static bool IsFuture(this DateTime @this)
    {
        return @this > DateTime.Now;
    }
}