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
    ///     An object extension method that query if '@this' is assignable from.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <returns>true if assignable from, false if not.</returns>
    public static bool IsAssignableFrom<T>(this object @this)
    {
        var type = @this.GetType();
        return type.IsAssignableFrom(typeof(T));
    }

    /// <summary>
    ///     An object extension method that query if '@this' is assignable from.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="targetType">Type of the target.</param>
    /// <returns>true if assignable from, false if not.</returns>
    public static bool IsAssignableFrom(this object @this, Type targetType)
    {
        var type = @this.GetType();
        return type.IsAssignableFrom(targetType);
    }
}