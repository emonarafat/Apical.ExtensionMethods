#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that deserialize a string binary as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The desrialize binary as &lt;T&gt;</returns>
    public static T DeserializeBinary<T>(this string @this)
    {
        using var stream = new MemoryStream(Encoding.Default.GetBytes(@this));
        var binaryRead = new BinaryFormatter();
        return (T)binaryRead.Deserialize(stream);
    }

    /// <summary>
    ///     A string extension method that deserialize a string binary as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>The desrialize binary as &lt;T&gt;</returns>
    public static T DeserializeBinary<T>(this string @this, Encoding encoding)
    {
        using var stream = new MemoryStream(encoding.GetBytes(@this));
        var binaryRead = new BinaryFormatter();
        return (T)binaryRead.Deserialize(stream);
    }
}