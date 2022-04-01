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
    ///     An Array extension method that check if the array is lower then the specified index.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool WithinIndex(this Array @this, int index)
    {
        return index >= 0 && index < @this.Length;
    }

    /// <summary>
    ///     An Array extension method that check if the array is lower then the specified index.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <param name="dimension">(Optional) the dimension.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool WithinIndex(this Array @this, int index, int dimension = 0)
    {
        return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
    }
}