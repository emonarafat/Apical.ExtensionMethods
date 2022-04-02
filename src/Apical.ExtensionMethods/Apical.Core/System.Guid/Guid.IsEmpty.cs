#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

using System;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     The IsEmpty.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>true if empty, false if not.</returns>
    public static bool IsEmpty(this Guid @this)
    {
        return @this == Guid.Empty;
    }
}