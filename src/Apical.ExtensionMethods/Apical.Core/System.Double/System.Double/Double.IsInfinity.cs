#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Returns a value indicating whether the specified number evaluates to negative or positive infinity.
    /// </summary>
    /// <param name="d">A double-precision floating-point number.</param>
    /// <returns>true if  evaluates to  or ; otherwise, false.</returns>
    public static bool IsInfinity(this double d)
    {
        return double.IsInfinity(d);
    }
}