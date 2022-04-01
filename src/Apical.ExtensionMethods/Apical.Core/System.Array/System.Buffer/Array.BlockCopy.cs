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
    ///     Copies a specified number of bytes from a source array starting at a particular offset to a destination array
    ///     starting at a particular offset.
    /// </summary>
    /// <param name="src">The source buffer.</param>
    /// <param name="srcOffset">The zero-based byte offset into .</param>
    /// <param name="dst">The destination buffer.</param>
    /// <param name="dstOffset">The zero-based byte offset into .</param>
    /// <param name="count">The number of bytes to copy.</param>
    public static void BlockCopy(this Array src, int srcOffset, Array dst, int dstOffset, int count)
    {
        Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
    }
}