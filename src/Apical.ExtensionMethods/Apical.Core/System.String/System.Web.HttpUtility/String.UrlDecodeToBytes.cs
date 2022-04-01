#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Text;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a URL-encoded string into a decoded array of bytes.
    /// </summary>
    /// <param name="str">The string to decode.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static byte[] UrlDecodeToBytes(this string str)
    {
        return HttpUtility.UrlDecodeToBytes(str);
    }

    /// <summary>
    ///     Converts a URL-encoded string into a decoded array of bytes using the specified decoding object.
    /// </summary>
    /// <param name="str">The string to decode.</param>
    /// <param name="e">The  object that specifies the decoding scheme.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static byte[] UrlDecodeToBytes(this string str, Encoding e)
    {
        return HttpUtility.UrlDecodeToBytes(str, e);
    }
}