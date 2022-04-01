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
    ///     A string extension method that if empty.
    /// </summary>
    /// <param name="value">The value to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>A string.</returns>
    public static string IfEmpty(this string value, string defaultValue)
    {
        return value.IsNotEmpty() ? value : defaultValue;
    }
}