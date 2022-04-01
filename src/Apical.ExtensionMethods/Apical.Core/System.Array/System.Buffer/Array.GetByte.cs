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
    ///     Retrieves the byte at a specified location in a specified array.
    /// </summary>
    /// <param name="array">An array.</param>
    /// <param name="index">A location in the array.</param>
    /// <returns>Returns the  byte in the array.</returns>
    public static byte GetByte(this Array array, int index)
    {
        return Buffer.GetByte(array, index);
    }
}