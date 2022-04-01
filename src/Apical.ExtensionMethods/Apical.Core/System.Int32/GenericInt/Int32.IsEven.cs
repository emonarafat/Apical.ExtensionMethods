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
    ///     An Int32 extension method that query if '@this' is even.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>true if even, false if not.</returns>
    public static bool IsEven(this int @this)
    {
        return @this % 2 == 0;
    }
}