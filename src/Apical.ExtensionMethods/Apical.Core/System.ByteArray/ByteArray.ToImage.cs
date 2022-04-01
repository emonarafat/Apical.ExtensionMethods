#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Drawing;
using System.IO;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A byte[] extension method that converts the @this to an image.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>@this as an Image.</returns>
    public static Image ToImage(this byte[] @this)
    {
        using var ms = new MemoryStream(@this);
        return Image.FromStream(ms);
    }
}