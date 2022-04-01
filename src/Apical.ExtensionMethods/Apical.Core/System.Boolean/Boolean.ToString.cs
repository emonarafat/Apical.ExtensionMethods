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
    ///     A bool extension method that show the trueValue when the @this value is true; otherwise show the falseValue.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="trueValue">The true value to be returned if the @this value is true.</param>
    /// <param name="falseValue">The false value to be returned if the @this value is false.</param>
    /// <returns>A string that represents of the current boolean value.</returns>
    public static string ToString(this bool @this, string trueValue, string falseValue)
    {
        return @this ? trueValue : falseValue;
    }
}