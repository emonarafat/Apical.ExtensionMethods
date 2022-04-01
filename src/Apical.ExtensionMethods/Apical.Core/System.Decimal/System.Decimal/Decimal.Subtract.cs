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
    ///     Subtracts one specified  value from another.
    /// </summary>
    /// <param name="d1">The minuend.</param>
    /// <param name="d2">The subtrahend.</param>
    /// <returns>The result of subtracting  from .</returns>
    public static decimal Subtract(this decimal d1, decimal d2)
    {
        return decimal.Subtract(d1, d2);
    }
}