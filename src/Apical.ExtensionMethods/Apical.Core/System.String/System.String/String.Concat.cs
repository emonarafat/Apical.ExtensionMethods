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
    ///     Concatenates two specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <returns>The concatenation of  and .</returns>
    public static string Concat(this string str0, string str1)
    {
        return string.Concat(str0, str1);
    }

    /// <summary>
    ///     Concatenates three specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <param name="str2">The third string to concatenate.</param>
    /// <returns>The concatenation of , , and .</returns>
    public static string Concat(this string str0, string str1, string str2)
    {
        return string.Concat(str0, str1, str2);
    }

    /// <summary>
    ///     Concatenates four specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <param name="str2">The third string to concatenate.</param>
    /// <param name="str3">The fourth string to concatenate.</param>
    /// <returns>The concatenation of , , , and .</returns>
    public static string Concat(this string str0, string str1, string str2, string str3)
    {
        return string.Concat(str0, str1, str2, str3);
    }
}