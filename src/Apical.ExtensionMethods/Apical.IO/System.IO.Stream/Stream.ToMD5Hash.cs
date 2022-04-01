#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.Security.Cryptography;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A Stream extension method that converts the @this to a md 5 hash.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToMD5Hash(this Stream @this)
    {
        using var md5 = MD5.Create();
        var hashBytes = md5.ComputeHash(@this);
        var sb = new StringBuilder();
        foreach (var bytes in hashBytes) sb.Append(bytes.ToString("X2"));

        return sb.ToString();
    }
}