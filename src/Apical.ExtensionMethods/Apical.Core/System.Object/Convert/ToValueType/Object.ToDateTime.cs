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
    ///     An object extension method that converts the @this to a date time.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>@this as a DateTime.</returns>
    public static DateTime ToDateTime(this object @this)
    {
        return Convert.ToDateTime(@this);
    }
}