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
    ///     Converts a string into a URL-encoded array of bytes.
    /// </summary>
    /// <param name="str">The string to encode.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static byte[] UrlEncodeToBytes(this string str)
    {
        return HttpUtility.UrlEncodeToBytes(str);
    }

    /// <summary>
    ///     Converts a string into a URL-encoded array of bytes using the specified encoding object.
    /// </summary>
    /// <param name="str">The string to encode.</param>
    /// <param name="e">The  that specifies the encoding scheme.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static byte[] UrlEncodeToBytes(this string str, Encoding e)
    {
        return HttpUtility.UrlEncodeToBytes(str, e);
    }
}