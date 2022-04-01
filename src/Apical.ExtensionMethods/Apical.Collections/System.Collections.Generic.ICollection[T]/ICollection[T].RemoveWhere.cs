#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that removes value that satisfy the predicate.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="predicate">The predicate.</param>
    public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
    {
        var list = @this.Where(predicate).ToList();
        foreach (var item in list) @this.Remove(item);
    }
}