#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that decrypt a string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key.</param>
    /// <returns>The decrypted string.</returns>
    public static string DecryptRSA(this string @this, string key)
    {
        var cspp = new CspParameters { KeyContainerName = key };
        var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
        var decryptArray = @this.Split(new[] { "-" }, StringSplitOptions.None);
        var decryptByteArray =
            Array.ConvertAll(decryptArray, s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber)));
        var bytes = rsa.Decrypt(decryptByteArray, true);

        return Encoding.UTF8.GetString(bytes);
    }
}