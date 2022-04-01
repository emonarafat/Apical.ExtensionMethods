#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.IO;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that appends all lines.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="contents">The contents.</param>
    public static void AppendAllLines(this FileInfo @this, IEnumerable<string> contents)
    {
        File.AppendAllLines(@this.FullName, contents);
    }

    /// <summary>
    ///     A FileInfo extension method that appends all lines.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="contents">The contents.</param>
    /// <param name="encoding">The encoding.</param>
    public static void AppendAllLines(this FileInfo @this, IEnumerable<string> contents, Encoding encoding)
    {
        File.AppendAllLines(@this.FullName, contents, encoding);
    }
}