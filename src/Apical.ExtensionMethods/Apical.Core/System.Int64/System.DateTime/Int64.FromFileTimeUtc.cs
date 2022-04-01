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
    ///     Converts the specified Windows file time to an equivalent UTC time.
    /// </summary>
    /// <param name="fileTime">A Windows file time expressed in ticks.</param>
    /// <returns>The <see cref="DateTime" />.</returns>
    public static DateTime FromFileTimeUtc(this long fileTime)
    {
        return DateTime.FromFileTimeUtc(fileTime);
    }
}