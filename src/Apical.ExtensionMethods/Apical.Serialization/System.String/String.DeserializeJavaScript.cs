#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

#if !NETSTANDARD
using System.Web.Script.Serialization;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A string extension method that deserialize a string binary as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The desrialize binary as &lt;T&gt;</returns>
    public static T DeserializeJavaScript<T>(this string @this)
    {
        var serializer = new JavaScriptSerializer();
        return serializer.Deserialize<T>(@this);
    }
#endif
}