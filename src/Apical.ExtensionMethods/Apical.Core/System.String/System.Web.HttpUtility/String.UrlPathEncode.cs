#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Encodes the path portion of a URL string for reliable HTTP transmission from the Web server to a client.
    /// </summary>
    /// <param name="str">The text to encode.</param>
    /// <returns>The encoded text.</returns>
    public static string UrlPathEncode(this string str)
    {
        return HttpUtility.UrlPathEncode(str);
    }
}