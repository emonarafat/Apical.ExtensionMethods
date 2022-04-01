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
    ///     Indicates whether the specified  object is a high surrogate.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>The <see cref="bool" />.</returns>
    public static bool IsHighSurrogate(this char c)
    {
        return char.IsHighSurrogate(c);
    }
}