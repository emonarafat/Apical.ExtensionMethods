#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A DirectoryInfo extension method that gets a size.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The size.</returns>
    public static long GetSize(this DirectoryInfo @this)
    {
        return @this.GetFiles("*.*", SearchOption.AllDirectories).Sum(x => x.Length);
    }
}