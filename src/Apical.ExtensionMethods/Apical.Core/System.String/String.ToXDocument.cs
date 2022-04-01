#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a XDocument.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an XDocument.</returns>
    public static XDocument ToXDocument(this string @this)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        using var ms = new MemoryStream(encoding.GetBytes(@this));
        return XDocument.Load(ms);
    }
}