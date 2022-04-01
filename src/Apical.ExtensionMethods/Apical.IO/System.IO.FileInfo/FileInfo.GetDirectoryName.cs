#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that gets directory name.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The directory name.</returns>
    public static string GetDirectoryName(this FileInfo @this)
    {
        return @this.Directory.Name;
    }
}