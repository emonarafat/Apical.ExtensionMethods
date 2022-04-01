#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.Linq;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     The MergeDistinctInnerEnumerable.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <returns>The <see cref="IEnumerable{T}" />.</returns>
    public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
    {
        var listItem = @this.ToList();

        var list = new List<T>();

        foreach (var item in listItem) list = list.Union(item).ToList();

        return list;
    }
}