#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

#if NET45_OR_GREATER
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     Extracts all the files in the specified zip archive to a directory on the file system
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="destinationDirectoryName">
    ///     The path to the directory in which to place the
    ///     extracted files, specified as a relative or absolute path. A relative path is interpreted as
    ///     relative to the current working directory.
    /// </param>
    public static void ExtractZipFileToDirectory(this FileInfo @this, string destinationDirectoryName)
    {
        ZipFile.ExtractToDirectory(@this.FullName, destinationDirectoryName);
    }

    /// <summary>
    ///     Extracts all the files in the specified zip archive to a directory on the file system and uses the specified
    ///     character encoding for entry names.
    /// </summary>
    /// <param name="this">The path to the archive that is to be extracted.</param>
    /// <param name="destinationDirectoryName">
    ///     The path to the directory in which to place the extracted files, specified as a
    ///     relative or absolute path. A relative path is interpreted as relative to the current working directory.
    /// </param>
    /// <param name="entryNameEncoding">
    ///     The encoding to use when reading or writing entry names in this archive. Specify a
    ///     value for this parameter only when an encoding is required for interoperability with zip archive tools and
    ///     libraries that do not support UTF-8 encoding for entry names.
    /// </param>
    public static void ExtractZipFileToDirectory(this FileInfo @this, string destinationDirectoryName, Encoding entryNameEncoding)
    {
        ZipFile.ExtractToDirectory(@this.FullName, destinationDirectoryName, entryNameEncoding);
    }

    /// <summary>Extracts all the files in the specified zip archive to a directory on the file system.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="destinationDirectory">Pathname of the destination directory.</param>
    public static void ExtractZipFileToDirectory(this FileInfo @this, DirectoryInfo destinationDirectory)
    {
        ZipFile.ExtractToDirectory(@this.FullName, destinationDirectory.FullName);
    }

    /// <summary>
    ///     Extracts all the files in the specified zip archive to a directory on the file system
    ///     and uses the specified character encoding for entry names.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="destinationDirectory">Pathname of the destination directory.</param>
    /// <param name="entryNameEncoding">
    ///     The encoding to use when reading or writing entry names in
    ///     this archive. Specify a value for this parameter only when an encoding is required for
    ///     interoperability with zip archive tools and libraries that do not support UTF-8 encoding for
    ///     entry names.
    /// </param>
    public static void ExtractZipFileToDirectory(this FileInfo @this, DirectoryInfo destinationDirectory, Encoding entryNameEncoding)
    {
        ZipFile.ExtractToDirectory(@this.FullName, destinationDirectory.FullName, entryNameEncoding);
    }
}
#endif