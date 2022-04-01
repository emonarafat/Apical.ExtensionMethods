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
    ///     A string extension method that queries if '@this' is not (null or empty).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if '@this' is not (null or empty), false if not.</returns>
    public static bool IsNotNullOrEmpty(this string @this)
    {
        return !string.IsNullOrEmpty(@this);
    }
}