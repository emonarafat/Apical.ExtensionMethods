#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Collections;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Searches a range of elements in a one-dimensional sorted  for a value, using the  interface implemented by
    ///     each element of the  and by the specified value.
    /// </summary>
    /// <param name="array">The sorted one-dimensional  to search.</param>
    /// <param name="index">The starting index of the range to search.</param>
    /// <param name="length">The length of the range to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <returns>The <see cref="Int32" />.</returns>
    public static int BinarySearch(this Array array, int index, int length, object value)
    {
        return Array.BinarySearch(array, index, length, value);
    }

    /// <summary>
    ///     Searches a range of elements in a one-dimensional sorted  for a value, using the specified  interface.
    /// </summary>
    /// <param name="array">The sorted one-dimensional  to search.</param>
    /// <param name="index">The starting index of the range to search.</param>
    /// <param name="length">The length of the range to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <param name="comparer">The comparer<see cref="IComparer" />.</param>
    /// <returns>The <see cref="Int32" />.</returns>
    public static int BinarySearch(this Array array, int index, int length, object value, IComparer comparer)
    {
        return Array.BinarySearch(array, index, length, value, comparer);
    }

    /// <summary>
    ///     Searches an entire one-dimensional sorted  for a specific element, using the  interface implemented by each
    ///     element of the  and by the specified object.
    /// </summary>
    /// <param name="array">The sorted one-dimensional  to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <returns>The <see cref="Int32" />.</returns>
    public static int BinarySearch(this Array array, object value)
    {
        return Array.BinarySearch(array, value);
    }

    /// <summary>
    ///     Searches an entire one-dimensional sorted  for a value using the specified  interface.
    /// </summary>
    /// <param name="array">The sorted one-dimensional  to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <param name="comparer">The comparer<see cref="IComparer" />.</param>
    /// <returns>The <see cref="Int32" />.</returns>
    public static int BinarySearch(this Array array, object value, IComparer comparer)
    {
        return Array.BinarySearch(array, value, comparer);
    }
}