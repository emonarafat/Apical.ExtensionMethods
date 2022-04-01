#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Linq;
using System.Xml.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An XElement extension method that removes all namespaces described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An XElement.</returns>
    public static XElement RemoveAllNamespaces(this XElement @this)
    {
        return new XElement(@this.Name.LocalName,
            from n in @this.Nodes()
            select n is XElement ? RemoveAllNamespaces(n as XElement) : n,
            @this.HasAttributes ? from a in @this.Attributes() select a : null);
    }
}