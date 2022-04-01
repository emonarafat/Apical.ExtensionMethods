#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Linq;
using System.Text.RegularExpressions;

public static partial class Extensions
{
    /// <summary>A string extension method that query if '@this' is palindrome.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if palindrome, false if not.</returns>
    public static bool IsPalindrome(this string @this)
    {
        // Keep only alphanumeric characters

        var rgx = new Regex("[^a-zA-Z0-9]");
        @this = rgx.Replace(@this, "");
        return @this.SequenceEqual(@this.Reverse());
    }
}