#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Multiplies two specified  values.
    /// </summary>
    /// <param name="d1">The multiplicand.</param>
    /// <param name="d2">The multiplier.</param>
    /// <returns>The result of multiplying  and .</returns>
    public static decimal Multiply(this decimal d1, decimal d2)
    {
        return decimal.Multiply(d1, d2);
    }
}