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
    ///     Retrieves a reference to a specified .
    /// </summary>
    /// <param name="str">The string to search for in the intern pool.</param>
    /// <returns>A reference to  if it is in the common language runtime intern pool; otherwise, null.</returns>
    public static string IsInterned(this string str)
    {
        return string.IsInterned(str);
    }
}