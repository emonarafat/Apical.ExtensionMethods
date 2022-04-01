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
    ///     Converts a string that has been HTML-encoded for HTTP transmission into a decoded string.
    /// </summary>
    /// <param name="s">The string to decode.</param>
    /// <returns>A decoded string.</returns>
    public static string HtmlDecode(this string s)
    {
        return HttpUtility.HtmlDecode(s);
    }

    /// <summary>
    ///     Converts a string that has been HTML-encoded into a decoded string, and sends the decoded string to a  output
    ///     stream.
    /// </summary>
    /// <param name="s">The string to decode.</param>
    /// <param name="output">A  stream of output.</param>
    public static void HtmlDecode(this string s, TextWriter output)
    {
        HttpUtility.HtmlDecode(s, output);
    }
}