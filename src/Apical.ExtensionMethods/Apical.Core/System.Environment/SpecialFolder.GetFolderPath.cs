#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     The GetFolderPath.
    /// </summary>
    /// <param name="this">this.</param>
    /// <returns>The folder path.</returns>
    public static string GetFolderPath(this Environment.SpecialFolder @this)
    {
        return Environment.GetFolderPath(@this);
    }

    /// <summary>
    ///     The GetFolderPath.
    /// </summary>
    /// <param name="this">this.</param>
    /// <param name="option">The option.</param>
    /// <returns>The folder path.</returns>
    public static string GetFolderPath(this Environment.SpecialFolder @this, Environment.SpecialFolderOption option)
    {
        return Environment.GetFolderPath(@this, option);
    }
}