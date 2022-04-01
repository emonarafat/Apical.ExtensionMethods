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
    ///     Returns the number of bytes in the specified array.
    /// </summary>
    /// <param name="array">An array.</param>
    /// <returns>The number of bytes in the array.</returns>
    public static int ByteLength(this Array array)
    {
        return Buffer.ByteLength(array);
    }
}