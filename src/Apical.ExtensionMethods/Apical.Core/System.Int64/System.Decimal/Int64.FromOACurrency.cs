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
    ///     Converts the specified 64-bit signed integer, which contains an OLE Automation Currency value, to the
    ///     equivalent  value.
    /// </summary>
    /// <param name="cy">An OLE Automation Currency value.</param>
    /// <returns>A  that contains the equivalent of .</returns>
    public static decimal FromOACurrency(this long cy)
    {
        return decimal.FromOACurrency(cy);
    }
}