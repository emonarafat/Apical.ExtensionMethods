#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Concatenates all the elements of a IEnumerable, using the specified separator between
    ///     each element.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="separator">The separator<see cref="char" />.</param>
    /// <returns>The <see cref="string" />.</returns>
    public static string StringJoin<T>(this IEnumerable<T> @this, char separator)
    {
        return string.Join(separator.ToString(), @this);
    }

    /// <summary>
    ///     Concatenates all the elements of a IEnumerable, using the specified separator between each element.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">An IEnumerable that contains the elements to concatenate.</param>
    /// <param name="separator">The separator<see cref="string" />.</param>
    /// <returns>The <see cref="string" />.</returns>
    public static string StringJoin<T>(this IEnumerable<T> @this, string separator)
    {
        return string.Join(separator, @this);
    }
}