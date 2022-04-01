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
    ///     A T extension method that serialize java script.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string SerializeJavaScript<T>(this T @this)
    {
        var serializer = new JavaScriptSerializer();
        return serializer.Serialize(@this);
    }
#endif
}