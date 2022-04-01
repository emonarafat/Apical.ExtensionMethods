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
    ///     A string extension method that query if '@this' is Alpha.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if Alpha, false if not.</returns>
    public static bool IsAlpha(this string @this)
    {
        return !Regex.IsMatch(@this, "[^a-zA-Z]");
    }
}