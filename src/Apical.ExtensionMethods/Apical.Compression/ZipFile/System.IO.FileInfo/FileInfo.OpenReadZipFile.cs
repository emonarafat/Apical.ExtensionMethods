#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

#if NET45_OR_GREATER
using System.IO;
using System.IO.Compression;

public static partial class Extensions
{
    /// <summary>
    ///     The path to the archive to open, specified as a relative or absolute path. A relative path is interpreted as
    ///     relative to the current working directory.
    /// </summary>
    /// <param name="this">
    ///     The path to the archive to open, specified as a relative or absolute path. A relative path is
    ///     interpreted as relative to the current working directory.
    /// </param>
    /// <returns>The opened zip archive.</returns>
    public static ZipArchive OpenReadZipFile(this FileInfo @this)
    {
        return ZipFile.OpenRead(@this.FullName);
    }
}
#endif