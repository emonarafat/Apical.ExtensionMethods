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
    ///     Sorts the elements in an entire one-dimensional  using the  implementation of each element of the .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    public static void Sort(this Array array)
    {
        Array.Sort(array);
    }

    /// <summary>
    ///     Sorts a pair of one-dimensional  objects (one contains the keys and the other contains the corresponding
    ///     items) based on the keys in the first  using the  implementation of each key.
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="items">The items<see cref="Array" />.</param>
    public static void Sort(this Array array, Array items)
    {
        Array.Sort(array, items);
    }

    /// <summary>
    ///     Sorts a pair of one-dimensional  objects (one contains the keys and the other contains the corresponding
    ///     items) based on the keys in the first  using the specified .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="items">The items<see cref="Array" />.</param>
    /// <param name="comparer">The comparer<see cref="IComparer" />.</param>
    public static void Sort(this Array array, Array items, IComparer comparer)
    {
        Array.Sort(array, items, comparer);
    }

    /// <summary>
    ///     Sorts a range of elements in a pair of one-dimensional  objects (one contains the keys and the other contains
    ///     the corresponding items) based on the keys in the first  using the  implementation of each key.
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="items">The items<see cref="Array" />.</param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    public static void Sort(this Array array, Array items, int index, int length)
    {
        Array.Sort(array, items, index, length);
    }

    /// <summary>
    ///     Sorts a range of elements in a pair of one-dimensional  objects (one contains the keys and the other contains
    ///     the corresponding items) based on the keys in the first  using the specified .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="items">The items<see cref="Array" />.</param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    /// <param name="comparer">The comparer<see cref="IComparer" />.</param>
    public static void Sort(this Array array, Array items, int index, int length, IComparer comparer)
    {
        Array.Sort(array, items, index, length, comparer);
    }

    /// <summary>
    ///     Sorts the elements in a one-dimensional  using the specified .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="comparer">The comparer<see cref="IComparer" />.</param>
    public static void Sort(this Array array, IComparer comparer)
    {
        Array.Sort(array, comparer);
    }

    /// <summary>
    ///     Sorts the elements in a range of elements in a one-dimensional  using the  implementation of each element of
    ///     the .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    public static void Sort(this Array array, int index, int length)
    {
        Array.Sort(array, index, length);
    }

    /// <summary>
    ///     Sorts the elements in a range of elements in a one-dimensional  using the specified .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    /// <param name="comparer">The comparer<see cref="IComparer" />.</param>
    public static void Sort(this Array array, int index, int length, IComparer comparer)
    {
        Array.Sort(array, index, length, comparer);
    }
}