#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Globalization;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Categorizes a specified Unicode character into a group identified by one of the  values.
    /// </summary>
    /// <param name="c">The Unicode character to categorize.</param>
    /// <returns>A  value that identifies the group that contains .</returns>
    public static UnicodeCategory GetUnicodeCategory(this char c)
    {
        return char.GetUnicodeCategory(c);
    }
}