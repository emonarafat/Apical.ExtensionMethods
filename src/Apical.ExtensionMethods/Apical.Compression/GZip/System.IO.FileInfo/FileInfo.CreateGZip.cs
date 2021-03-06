#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.IO.Compression;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that creates a zip file.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    public static void CreateGZip(this FileInfo @this)
    {
        using var originalFileStream = @this.OpenRead();
        using var compressedFileStream = File.Create(@this.FullName + ".gz");
        using var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress);
        originalFileStream.CopyTo(compressionStream);
    }

    /// <summary>
    ///     A FileInfo extension method that creates a zip file.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="destination">Destination for the zip.</param>
    public static void CreateGZip(this FileInfo @this, FileInfo destination)
    {
        using var originalFileStream = @this.OpenRead();
        using var compressedFileStream = File.Create(destination.FullName);
        using var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress);
        originalFileStream.CopyTo(compressionStream);
    }

    /// <summary>
    ///     A FileInfo extension method that creates a zip file.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="destination">Destination for the zip.</param>
    public static void CreateGZip(this FileInfo @this, string destination)
    {
        using var originalFileStream = @this.OpenRead();
        using var compressedFileStream = File.Create(destination);
        using var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress);
        originalFileStream.CopyTo(compressionStream);
    }
}