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
    ///     Translates an OLE color value to a GDI+  structure.
    /// </summary>
    /// <param name="oleColor">The OLE color to translate.</param>
    /// <returns>The  structure that represents the translated OLE color.</returns>
    public static Color FromOle(this int oleColor)
    {
        return ColorTranslator.FromOle(oleColor);
    }
}