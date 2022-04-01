#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Xml;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to an XmlDocument.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an XmlDocument.</returns>
    public static XmlDocument ToXmlDocument(this string @this)
    {
        var doc = new XmlDocument();
        doc.LoadXml(@this);
        return doc;
    }
}