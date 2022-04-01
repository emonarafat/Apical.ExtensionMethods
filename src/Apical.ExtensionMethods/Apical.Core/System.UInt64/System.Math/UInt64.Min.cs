#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the smaller of two 64-bit unsigned integers.
    /// </summary>
    /// <param name="val1">The first of two 64-bit unsigned integers to compare.</param>
    /// <param name="val2">The second of two 64-bit unsigned integers to compare.</param>
    /// <returns>Parameter  or , whichever is smaller.</returns>
    public static ulong Min(this ulong val1, ulong val2)
    {
        return Math.Min(val1, val2);
    }
}