#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

using System;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     An Int16 extension method that hours the given this.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>A TimeSpan.</returns>
    public static TimeSpan Hours(this short @this)
    {
        return TimeSpan.FromHours(@this);
    }
}