#region Copyright

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// // Copyright © Apical Automates . 2022  All rights reserved.

#endregion

using System;
using System.Drawing;

public static partial class Extensions
{
    /// <summary>
    ///     Translates the specified  structure to an OLE color.
    /// </summary>
    /// <param name="c">The  structure to translate.</param>
    /// <returns>The OLE color value.</returns>
    public static int ToOle(this Color c)
    {
        return ColorTranslator.ToOle(c);
    }
}