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
    ///     Retrieves the system&#39;s reference to the specified .
    /// </summary>
    /// <param name="str">A string to search for in the intern pool.</param>
    /// <returns>
    ///     The system&#39;s reference to , if it is interned; otherwise, a new reference to a string with the value of .
    /// </returns>
    public static string Intern(this string str)
    {
        return string.Intern(str);
    }
}