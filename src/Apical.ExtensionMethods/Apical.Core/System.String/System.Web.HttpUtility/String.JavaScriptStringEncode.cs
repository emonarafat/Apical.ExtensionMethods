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
    ///     Encodes a string.
    /// </summary>
    /// <param name="value">A string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string JavaScriptStringEncode(this string value)
    {
        return HttpUtility.JavaScriptStringEncode(value);
    }

    /// <summary>
    ///     Encodes a string.
    /// </summary>
    /// <param name="value">A string to encode.</param>
    /// <param name="addDoubleQuotes">
    ///     A value that indicates whether double quotation marks will be included around the
    ///     encoded string.
    /// </param>
    /// <returns>An encoded string.</returns>
    public static string JavaScriptStringEncode(this string value, bool addDoubleQuotes)
    {
        return HttpUtility.JavaScriptStringEncode(value, addDoubleQuotes);
    }
}