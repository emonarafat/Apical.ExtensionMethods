#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.IO;
using System.Linq;
public static partial class Extensions
{
    /// <summary>
    ///     An IEnumerable&lt;DirectoryInfo&gt; extension method that deletes the given @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="recursive"><see cref="bool"/> whether delete subdirectories and files</param>
    public static void Delete(this IEnumerable<DirectoryInfo> @this, bool recursive = true)
    {
        foreach (var t in @this) t.Delete(recursive);
    }
}