#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Text;

public static partial class Extensions
{
    /// <summary>A StringBuilder extension method that substrings.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>A string.</returns>
    public static string Substring(this StringBuilder @this, int startIndex)
    {
        return @this.ToString(startIndex, @this.Length - startIndex);
    }

    /// <summary>A StringBuilder extension method that substrings.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="length">The length.</param>
    /// <returns>A string.</returns>
    public static string Substring(this StringBuilder @this, int startIndex, int length)
    {
        return @this.ToString(startIndex, length);
    }
}