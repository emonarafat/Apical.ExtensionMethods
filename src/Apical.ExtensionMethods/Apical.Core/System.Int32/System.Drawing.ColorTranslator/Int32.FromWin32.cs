#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Drawing;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Translates a Windows color value to a GDI+  structure.
    /// </summary>
    /// <param name="win32Color">The Windows color to translate.</param>
    /// <returns>The  structure that represents the translated Windows color.</returns>
    public static Color FromWin32(this int win32Color)
    {
        return ColorTranslator.FromWin32(win32Color);
    }
}