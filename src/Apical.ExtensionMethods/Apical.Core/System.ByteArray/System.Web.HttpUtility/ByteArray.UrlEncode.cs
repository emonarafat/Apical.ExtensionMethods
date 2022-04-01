#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Web;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Converts a byte array into an encoded URL string.
    /// </summary>
    /// <param name="bytes">The array of bytes to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string UrlEncode(this byte[] bytes)
    {
        return HttpUtility.UrlEncode(bytes);
    }

    /// <summary>
    ///     Converts a byte array into a URL-encoded string, starting at the specified position in the array and
    ///     continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to encode.</param>
    /// <param name="offset">The position in the byte array at which to begin encoding.</param>
    /// <param name="count">The number of bytes to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string UrlEncode(this byte[] bytes, int offset, int count)
    {
        return HttpUtility.UrlEncode(bytes, offset, count);
    }
}