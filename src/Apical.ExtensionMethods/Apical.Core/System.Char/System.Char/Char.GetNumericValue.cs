#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified numeric Unicode character to a double-precision floating point number.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>The numeric value of  if that character represents a number; otherwise, -1.0.</returns>
    public static double GetNumericValue(this char c)
    {
        return char.GetNumericValue(c);
    }
}