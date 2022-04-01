#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.Linq;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Enumerates from @this to toCharacter.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="toCharacter">to character.</param>
    /// <returns>An enumerator that allows foreach to be used to process @this to toCharacter.</returns>
    public static IEnumerable<char> To(this char @this, char toCharacter)
    {
        var reverseRequired = @this > toCharacter;

        var first = reverseRequired ? toCharacter : @this;
        var last = reverseRequired ? @this : toCharacter;

        var result = Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode);

        if (reverseRequired) result = result.Reverse();


        return result;
    }
}