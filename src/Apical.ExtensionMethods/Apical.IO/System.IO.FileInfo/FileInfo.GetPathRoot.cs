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
    ///     Gets the root directory information of the specified @this.
    /// </summary>
    /// <param name="this">The @this from which to obtain root directory information.</param>
    /// <returns>
    ///     The root directory of <paramref name="this" />, such as "C:\", or null if <paramref name="this" /> is null,
    ///     or an empty string if
    ///     <paramref
    ///         name="this" />
    ///     does not contain root directory information.
    /// </returns>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> contains one or more of the invalid
    ///     characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .-or- <see cref="F:System.String.Empty" /> was passed to
    ///     <paramref
    ///         name="this" />
    ///     .
    /// </exception>
    public static string GetPathRoot(this FileInfo @this)
    {
        return Path.GetPathRoot(@this.FullName);
    }
}