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
    ///     Copies a range of elements from an  starting at the specified source index and pastes them to another
    ///     starting at the specified destination index.  Guarantees that all changes are undone if the copy does not
    ///     succeed completely.
    /// </summary>
    /// <param name="sourceArray">The  that contains the data to copy.</param>
    /// <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
    /// <param name="destinationArray">The  that receives the data.</param>
    /// <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
    /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
    public static void ConstrainedCopy(this Array sourceArray, int sourceIndex, Array destinationArray,
        int destinationIndex, int length)
    {
        Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
    }
}