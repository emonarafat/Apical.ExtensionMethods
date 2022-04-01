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
    ///     Returns the result of multiplying the specified  value by negative one.
    /// </summary>
    /// <param name="d">The value to negate.</param>
    /// <returns>A decimal number with the value of , but the opposite sign.-or- Zero, if  is zero.</returns>
    public static decimal Negate(this decimal d)
    {
        return decimal.Negate(d);
    }
}