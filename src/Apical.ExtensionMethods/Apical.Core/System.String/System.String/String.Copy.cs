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
    ///     Creates a new instance of  with the same value as a specified .
    /// </summary>
    /// <param name="str">The string to copy.</param>
    /// <returns>A new string with the same value as .</returns>
    public static string Copy(this string str)
    {
        return string.Copy(str);
    }
}