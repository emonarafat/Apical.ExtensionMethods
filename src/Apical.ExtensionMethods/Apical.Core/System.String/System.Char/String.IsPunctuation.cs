#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

public static partial class Extensions
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string is categorized as a
    ///     punctuation mark.
    /// </summary>
    /// <param name="s">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>true if the character at position  in  is a punctuation mark; otherwise, false.</returns>
    public static bool IsPunctuation(this string s, int index)
    {
        return char.IsPunctuation(s, index);
    }
}