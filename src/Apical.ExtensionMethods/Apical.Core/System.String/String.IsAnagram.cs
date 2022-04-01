#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that query if '@this' is anagram of other String.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="otherString">The other string</param>
    /// <returns>true if the @this is anagram of the otherString, false if not.</returns>
    public static bool IsAnagram(this string @this, string otherString)
    {
        return @this
            .OrderBy(c => c)
            .SequenceEqual(otherString.OrderBy(c => c));
    }
}