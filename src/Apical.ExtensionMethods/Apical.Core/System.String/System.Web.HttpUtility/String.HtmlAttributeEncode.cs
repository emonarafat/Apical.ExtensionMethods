#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Minimally converts a string to an HTML-encoded string.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string HtmlAttributeEncode(this string s)
    {
        return HttpUtility.HtmlAttributeEncode(s);
    }

    /// <summary>
    ///     Minimally converts a string into an HTML-encoded string and sends the encoded string to a  output stream.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <param name="output">A  output stream.</param>
    public static void HtmlAttributeEncode(this string s, TextWriter output)
    {
        HttpUtility.HtmlAttributeEncode(s, output);
    }
}