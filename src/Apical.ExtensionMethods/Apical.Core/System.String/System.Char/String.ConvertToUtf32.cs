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
    ///     Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a
    ///     Unicode code point.
    /// </summary>
    /// <param name="s">A string that contains a character or surrogate pair.</param>
    /// <param name="index">The index position of the character or surrogate pair in .</param>
    /// <returns>The <see cref="int" />.</returns>
    public static int ConvertToUtf32(this string s, int index)
    {
        return char.ConvertToUtf32(s, index);
    }
}