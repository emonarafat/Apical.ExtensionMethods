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
    ///     Changes the extension of a @this string.
    /// </summary>
    /// <param name="this">
    ///     The @this information to modify. The @this cannot contain any of the characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </param>
    /// <param name="extension">
    ///     The new extension (with or without a leading period). Specify null to remove an existing
    ///     extension from
    ///     <paramref
    ///         name="this" />
    ///     .
    /// </param>
    /// <returns>
    ///     The modified @this information.On Windows-based desktop platforms, if <paramref name="this" /> is null or an
    ///     empty string (""), the @this information is returned unmodified. If
    ///     <paramref
    ///         name="extension" />
    ///     is null, the returned string contains the specified @this with its extension removed. If
    ///     <paramref
    ///         name="this" />
    ///     has no extension, and <paramref name="extension" /> is not null, the returned @this string contains
    ///     <paramref
    ///         name="extension" />
    ///     appended to the end of <paramref name="this" />.
    /// </returns>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> contains one or more of the invalid
    ///     characters defined in
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </exception>
    public static string ChangeExtension(this FileInfo @this, string extension)
    {
        return Path.ChangeExtension(@this.FullName, extension);
    }
}