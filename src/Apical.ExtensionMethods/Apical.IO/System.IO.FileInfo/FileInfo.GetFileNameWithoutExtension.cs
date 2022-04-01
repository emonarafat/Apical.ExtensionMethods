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
    ///     Returns the file name of the specified @this string without the extension.
    /// </summary>
    /// <param name="this">The @this of the file.</param>
    /// <returns>
    ///     The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.)
    ///     and all characters following it.
    /// </returns>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> contains one or more of the invalid
    ///     characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </exception>
    public static string GetFileNameWithoutExtension(this FileInfo @this)
    {
        return Path.GetFileNameWithoutExtension(@this.FullName);
    }
}