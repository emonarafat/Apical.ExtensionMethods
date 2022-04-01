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
    ///     A DirectoryInfo extension method that deletes the older than.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="timeSpan">The time span.</param>
    public static void DeleteOlderThan(this DirectoryInfo obj, TimeSpan timeSpan)
    {
        var minDate = DateTime.Now.Subtract(timeSpan);
        obj.GetFiles().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        obj.GetDirectories().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
    }

    /// <summary>
    ///     A DirectoryInfo extension method that deletes the older than.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="searchOption">The search option.</param>
    /// <param name="timeSpan">The time span.</param>
    public static void DeleteOlderThan(this DirectoryInfo obj, SearchOption searchOption, TimeSpan timeSpan)
    {
        var minDate = DateTime.Now.Subtract(timeSpan);
        obj.GetFiles("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        obj.GetDirectories("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
    }
}