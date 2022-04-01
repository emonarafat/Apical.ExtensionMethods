#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.IO.Compression;
using System.Text;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that compress the given string to GZip byte array.
    /// </summary>
    /// <param name="this">The stringToCompress to act on.</param>
    /// <returns>The string compressed into a GZip byte array.</returns>
    public static byte[] CompressGZip(this string @this)
    {
        var stringAsBytes = Encoding.Default.GetBytes(@this);
        using var memoryStream = new MemoryStream();
        using var zipStream = new GZipStream(memoryStream, CompressionMode.Compress);
        zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
        zipStream.Close();
        return memoryStream.ToArray();
    }

    /// <summary>
    ///     A string extension method that compress the given string to GZip byte array.
    /// </summary>
    /// <param name="this">The stringToCompress to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>The string compressed into a GZip byte array.</returns>
    public static byte[] CompressGZip(this string @this, Encoding encoding)
    {
        var stringAsBytes = encoding.GetBytes(@this);
        using var memoryStream = new MemoryStream();
        using var zipStream = new GZipStream(memoryStream, CompressionMode.Compress);
        zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
        zipStream.Close();
        return memoryStream.ToArray();
    }
}