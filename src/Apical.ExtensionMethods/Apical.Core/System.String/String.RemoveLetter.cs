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
    ///     A string extension method that removes the letter described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string RemoveLetter(this string @this)
    {
        return new string(@this.ToCharArray().Where(x => !char.IsLetter(x)).ToArray());
    }
}