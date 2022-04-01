#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Text;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that extracts the UInt16 from the string.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>The extracted UInt16.</returns>
    public static ushort ExtractUInt16(this string @this)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < @this.Length; i++)
            if (char.IsDigit(@this[i]))
                sb.Append(@this[i]);

        return Convert.ToUInt16(sb.ToString());
    }
}