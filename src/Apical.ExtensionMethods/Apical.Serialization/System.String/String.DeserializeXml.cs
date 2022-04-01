#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.Xml.Serialization;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that deserialize an Xml as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The desieralize Xml as &lt;T&gt;</returns>
    public static T DeserializeXml<T>(this string @this)
    {
        var x = new XmlSerializer(typeof(T));
        var r = new StringReader(@this);

        return (T)x.Deserialize(r);
    }
}