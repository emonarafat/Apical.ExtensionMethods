#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Specialized;
using System.Text;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Parses a query string into a  using  encoding.
    /// </summary>
    /// <param name="query">The query string to parse.</param>
    /// <returns>A  of query parameters and values.</returns>
    public static NameValueCollection ParseQueryString(this string query)
    {
        return HttpUtility.ParseQueryString(query);
    }

    /// <summary>
    ///     Parses a query string into a  using the specified .
    /// </summary>
    /// <param name="query">The query string to parse.</param>
    /// <param name="encoding">The  to use.</param>
    /// <returns>A  of query parameters and values.</returns>
    public static NameValueCollection ParseQueryString(this string query, Encoding encoding)
    {
        return HttpUtility.ParseQueryString(query, encoding);
    }
}