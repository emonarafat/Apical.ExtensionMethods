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
    ///     Divides two specified  values.
    /// </summary>
    /// <param name="d1">The dividend.</param>
    /// <param name="d2">The divisor.</param>
    /// <returns>The result of dividing  by .</returns>
    public static decimal Divide(this decimal d1, decimal d2)
    {
        return decimal.Divide(d1, d2);
    }
}