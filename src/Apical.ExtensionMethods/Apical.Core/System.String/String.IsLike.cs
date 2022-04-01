#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Text.RegularExpressions;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that query if '@this' satisfy the specified pattern.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="pattern">The pattern to use. Use '*' as wildcard string.</param>
    /// <returns>true if '@this' satisfy the specified pattern, false if not.</returns>
    public static bool IsLike(this string @this, string pattern)
    {
        // Turn the pattern into regex pattern, and match the whole string with ^$
        var regexPattern = "^" + Regex.Escape(pattern) + "$";

        // Escape special character ?, #, *, [], and [!]
        regexPattern = regexPattern.Replace(@"\[!", "[^")
            .Replace(@"\[", "[")
            .Replace(@"\]", "]")
            .Replace(@"\?", ".")
            .Replace(@"\*", ".*")
            .Replace(@"\#", @"\d");

        return Regex.IsMatch(@this, regexPattern);
    }
}