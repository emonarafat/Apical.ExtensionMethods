#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A DirectoryInfo extension method that deletes the files where.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="predicate">The predicate.</param>
    public static void DeleteFilesWhere(this DirectoryInfo obj, Func<FileInfo, bool> predicate)
    {
        obj.GetFiles().Where(predicate).ForEach(x => x.Delete());
    }

    /// <summary>
    ///     A DirectoryInfo extension method that deletes the files where.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="searchOption">The search option.</param>
    /// <param name="predicate">The predicate.</param>
    public static void DeleteFilesWhere(this DirectoryInfo obj, SearchOption searchOption,
        Func<FileInfo, bool> predicate)
    {
        obj.GetFiles("*.*", searchOption).Where(predicate).ForEach(x => x.Delete());
    }
}