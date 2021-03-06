#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Combines multiples string into a path.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="paths">A variable-length parameters list containing paths.</param>
    /// <returns>
    ///     The combined paths as a DirectoryInfo. If one of the specified paths is a zero-length string, this method
    ///     returns the other path.
    /// </returns>
    public static DirectoryInfo PathCombineDirectory(this DirectoryInfo @this, params string[] paths)
    {
        var list = paths.ToList();
        list.Insert(0, @this.FullName);
        return new DirectoryInfo(Path.Combine(list.ToArray()));
    }
}