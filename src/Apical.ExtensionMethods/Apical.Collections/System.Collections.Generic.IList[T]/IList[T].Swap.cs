#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that swaps item only when it exists in a collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="oldValue">The old value.</param>
    /// <param name="newValue">The new value.</param>
    public static void Swap<T>(this IList<T> @this, T oldValue, T newValue)
    {
        var oldIndex = @this.IndexOf(oldValue);
        while (oldIndex > 0)
        {
            @this.RemoveAt(oldIndex);
            @this.Insert(oldIndex, newValue);
            oldIndex = @this.IndexOf(oldValue);
        }
    }
}