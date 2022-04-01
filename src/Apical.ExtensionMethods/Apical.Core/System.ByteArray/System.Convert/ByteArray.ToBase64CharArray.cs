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
    ///     Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array
    ///     encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, and
    ///     the number of elements in the input array to convert.
    /// </summary>
    /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
    /// <param name="offsetIn">A position within .</param>
    /// <param name="length">The number of elements of  to convert.</param>
    /// <param name="outArray">An output array of Unicode characters.</param>
    /// <param name="offsetOut">A position within .</param>
    /// <returns>A 32-bit signed integer containing the number of bytes in .</returns>
    public static int ToBase64CharArray(this byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
    {
        return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);
    }

    /// <summary>
    ///     Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array
    ///     encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, the
    ///     number of elements in the input array to convert, and whether line breaks are inserted in the output array.
    /// </summary>
    /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
    /// <param name="offsetIn">A position within .</param>
    /// <param name="length">The number of elements of  to convert.</param>
    /// <param name="outArray">An output array of Unicode characters.</param>
    /// <param name="offsetOut">A position within .</param>
    /// <param name="options">to insert a line break every 76 characters, or  to not insert line breaks.</param>
    /// <returns>A 32-bit signed integer containing the number of bytes in .</returns>
    public static int ToBase64CharArray(this byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut,
        Base64FormattingOptions options)
    {
        return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);
    }
}