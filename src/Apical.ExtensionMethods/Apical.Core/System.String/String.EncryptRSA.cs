#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Security.Cryptography;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that encrypts the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key.</param>
    /// <returns>The encrypted string.</returns>
    public static string EncryptRSA(this string @this, string key)
    {
        var cspp = new CspParameters { KeyContainerName = key };
        var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
        var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(@this), true);

        return BitConverter.ToString(bytes);
    }
}