#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Security;

public static partial class Extensions
{
    /// <summary>
    ///     A String extension method that converts the @this to a secure string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a SecureString.</returns>
    public static SecureString ToSecureString(this string @this)
    {
        var secureString = new SecureString();
        foreach (var c in @this)
            secureString.AppendChar(c);

        return secureString;
    }
}