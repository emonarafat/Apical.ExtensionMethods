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
    ///     Reverses the sequence of the elements in the entire one-dimensional .
    /// </summary>
    /// <param name="array">The one-dimensional  to reverse.</param>
    public static void Reverse(this Array array)
    {
        Array.Reverse(array);
    }

    /// <summary>
    ///     Reverses the sequence of the elements in a range of elements in the one-dimensional .
    /// </summary>
    /// <param name="array">The one-dimensional  to reverse.</param>
    /// <param name="index">The starting index of the section to reverse.</param>
    /// <param name="length">The number of elements in the section to reverse.</param>
    public static void Reverse(this Array array, int index, int length)
    {
        Array.Reverse(array, index, length);
    }
}