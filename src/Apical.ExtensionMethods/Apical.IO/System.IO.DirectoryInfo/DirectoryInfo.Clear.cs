#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A DirectoryInfo extension method that clears all files and directories in this directory.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    public static void Clear(this DirectoryInfo obj)
    {
        Array.ForEach(obj.GetFiles(), x => x.Delete());
        Array.ForEach(obj.GetDirectories(), x => x.Delete(true));
    }
}