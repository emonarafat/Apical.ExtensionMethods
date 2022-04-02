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
    ///     An Int64 extension method that query if '@this' is prime.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>true if prime, false if not.</returns>
    public static bool IsPrime(this long @this)
    {
        if (@this == 1 || @this == 2) return true;

        if (@this % 2 == 0) return false;

        var sqrt = (long)Math.Sqrt(@this);
        for (long t = 3; t <= sqrt; t += 2)
            if (@this % t == 0)
                return false;

        return true;
    }
}