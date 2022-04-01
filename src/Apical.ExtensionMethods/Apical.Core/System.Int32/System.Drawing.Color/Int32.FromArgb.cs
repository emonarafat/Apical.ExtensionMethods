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
    ///     Creates a  structure from a 32-bit ARGB value.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <returns>The  structure that this method creates.</returns>
    public static Color FromArgb(this int argb)
    {
        return Color.FromArgb(argb);
    }

    /// <summary>
    ///     Creates a  structure from the specified  structure, but with the new specified alpha value. Although this
    ///     method allows a 32-bit value to be passed for the alpha value, the value is limited to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="baseColor">The  from which to create the new .</param>
    /// <returns>The  that this method creates.</returns>
    public static Color FromArgb(this int argb, Color baseColor)
    {
        return Color.FromArgb(argb, baseColor);
    }

    /// <summary>
    ///     Creates a  structure from the specified 8-bit color values (red, green, and blue). The alpha value is
    ///     implicitly 255 (fully opaque). Although this method allows a 32-bit value to be passed for each color
    ///     component, the value of each component is limited to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="green">The green component value for the new . Valid values are 0 through 255.</param>
    /// <param name="blue">The blue component value for the new . Valid values are 0 through 255.</param>
    /// <returns>The  that this method creates.</returns>
    public static Color FromArgb(this int argb, int green, int blue)
    {
        return Color.FromArgb(argb, green, blue);
    }

    /// <summary>
    ///     Creates a  structure from the four ARGB component (alpha, red, green, and blue) values. Although this method
    ///     allows a 32-bit value to be passed for each component, the value of each component is limited to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="red">The red component. Valid values are 0 through 255.</param>
    /// <param name="green">The green component. Valid values are 0 through 255.</param>
    /// <param name="blue">The blue component. Valid values are 0 through 255.</param>
    /// <returns>The  that this method creates.</returns>
    public static Color FromArgb(this int argb, int red, int green, int blue)
    {
        return Color.FromArgb(argb, red, green, blue);
    }
}