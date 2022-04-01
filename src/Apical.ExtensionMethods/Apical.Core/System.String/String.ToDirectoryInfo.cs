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
    ///     A string extension method that converts the @this to a directory information.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DirectoryInfo.</returns>
    public static DirectoryInfo ToDirectoryInfo(this string @this)
    {
        return new DirectoryInfo(@this);
    }
}