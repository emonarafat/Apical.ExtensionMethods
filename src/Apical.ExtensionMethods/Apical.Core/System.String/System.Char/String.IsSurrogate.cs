#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

public static partial class Extensions
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string has a surrogate code unit.
    /// </summary>
    /// <param name="s">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>
    ///     true if the character at position  in  is a either a high surrogate or a low surrogate; otherwise, false.
    /// </returns>
    public static bool IsSurrogate(this string s, int index)
    {
        return char.IsSurrogate(s, index);
    }
}