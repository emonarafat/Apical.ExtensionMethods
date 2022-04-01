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
    ///     A char extension method that repeats a character the specified number of times.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="repeatCount">Number of repeats.</param>
    /// <returns>The repeated char.</returns>
    public static string Repeat(this char @this, int repeatCount)
    {
        return new string(@this, repeatCount);
    }
}