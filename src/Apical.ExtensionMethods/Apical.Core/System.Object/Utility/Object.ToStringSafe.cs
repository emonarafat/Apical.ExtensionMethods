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
    ///     An object extension method that converts the @this to string or return an empty string if the value is null.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>@this as a string or empty if the value is null.</returns>
    public static string ToStringSafe(this object @this)
    {
        return @this == null ? "" : @this.ToString();
    }
}