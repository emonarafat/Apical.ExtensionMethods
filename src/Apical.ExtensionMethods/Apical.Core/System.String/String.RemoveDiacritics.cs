#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Globalization;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that removes the diacritics character from the strings.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The string without diacritics character.</returns>
    public static string RemoveDiacritics(this string @this)
    {
        var normalizedString = @this.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (var t in normalizedString)
        {
            var uc = CharUnicodeInfo.GetUnicodeCategory(t);
            if (uc != UnicodeCategory.NonSpacingMark) sb.Append(t);
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}