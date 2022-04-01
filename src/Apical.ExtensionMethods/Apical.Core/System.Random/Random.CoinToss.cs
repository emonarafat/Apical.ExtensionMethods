#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A Random extension method that flip a coin toss.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>true 50% of time, otherwise false.</returns>
    public static bool CoinToss(this Random @this)
    {
        return @this.Next(2) == 0;
    }
}