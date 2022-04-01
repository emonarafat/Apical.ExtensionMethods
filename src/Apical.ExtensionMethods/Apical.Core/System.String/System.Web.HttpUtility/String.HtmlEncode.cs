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
    ///     Converts a string to an HTML-encoded string.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string HtmlEncode(this string s)
    {
        return HttpUtility.HtmlEncode(s);
    }

    /// <summary>
    ///     Converts a string into an HTML-encoded string, and returns the output as a  stream of output.
    /// </summary>
    /// <param name="s">The string to encode.</param>
    /// <param name="output">A  output stream.</param>
    public static void HtmlEncode(this string s, TextWriter output)
    {
        HttpUtility.HtmlEncode(s, output);
    }
}