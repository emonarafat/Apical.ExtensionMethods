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
    ///     A string extension method that return null if the value is empty else the value.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>null if the value is empty, otherwise the value.</returns>
    public static string NullIfEmpty(this string @this)
    {
        return @this == "" ? null : @this;
    }
}