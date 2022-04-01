#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.IO;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a MemoryStream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a MemoryStream.</returns>
    public static Stream ToMemoryStream(this string @this)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        return new MemoryStream(encoding.GetBytes(@this));
    }
}