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
    ///     A string extension method that replace when equals.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="oldValue">The old value.</param>
    /// <param name="newValue">The new value.</param>
    /// <returns>The new value if the string equal old value; Otherwise old value.</returns>
    public static string ReplaceWhenEquals(this string @this, string oldValue, string newValue)
    {
        return @this == oldValue ? newValue : @this;
    }
}