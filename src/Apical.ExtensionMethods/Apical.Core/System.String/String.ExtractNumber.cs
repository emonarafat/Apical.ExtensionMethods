#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that extracts the number described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted number.</returns>
    public static string ExtractNumber(this string @this)
    {
        return new string(@this.ToCharArray().Where(x => char.IsNumber(x)).ToArray());
    }
}