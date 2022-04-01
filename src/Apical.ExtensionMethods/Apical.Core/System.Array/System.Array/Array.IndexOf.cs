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
    ///     Searches for the specified object and returns the index of the first occurrence within the entire one-
    ///     dimensional .
    /// </summary>
    /// <param name="array">The one-dimensional  to search.</param>
    /// <param name="value">The object to locate in .</param>
    /// <returns>The <see cref="Int32" />.</returns>
    public static int IndexOf(this Array array, object value)
    {
        return Array.IndexOf(array, value);
    }

    /// <summary>
    ///     Searches for the specified object and returns the index of the first occurrence within the range of elements
    ///     in the one-dimensional  that extends from the specified index to the last element.
    /// </summary>
    /// <param name="array">The one-dimensional  to search.</param>
    /// <param name="value">The object to locate in .</param>
    /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
    /// <returns>The <see cref="Int32" />.</returns>
    public static int IndexOf(this Array array, object value, int startIndex)
    {
        return Array.IndexOf(array, value, startIndex);
    }

    /// <summary>
    ///     Searches for the specified object and returns the index of the first occurrence within the range of elements
    ///     in the one-dimensional  that starts at the specified index and contains the specified number of elements.
    /// </summary>
    /// <param name="array">The one-dimensional  to search.</param>
    /// <param name="value">The object to locate in .</param>
    /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>The <see cref="Int32" />.</returns>
    public static int IndexOf(this Array array, object value, int startIndex, int count)
    {
        return Array.IndexOf(array, value, startIndex, count);
    }
}