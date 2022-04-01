#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that decode a Base64 String.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The Base64 String decoded.</returns>
    public static string DecodeBase64(this string @this)
    {
        return Encoding.ASCII.GetString(Convert.FromBase64String(@this));
    }
}