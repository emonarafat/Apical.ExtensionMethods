#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Subtracts an offset from the value of an unsigned pointer.
    /// </summary>
    /// <param name="pointer">The unsigned pointer to subtract the offset from.</param>
    /// <param name="offset">The offset to subtract.</param>
    /// <returns>A new unsigned pointer that reflects the subtraction of  from .</returns>
    public static UIntPtr Subtract(this UIntPtr pointer, int offset)
    {
        return UIntPtr.Subtract(pointer, offset);
    }
}