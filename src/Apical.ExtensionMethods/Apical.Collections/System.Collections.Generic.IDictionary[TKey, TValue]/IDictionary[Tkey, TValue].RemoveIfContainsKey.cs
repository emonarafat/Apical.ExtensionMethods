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
    ///     An IDictionary&lt;TKey,TValue&gt; extension method that removes if contains key.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="key">The key.</param>
    public static void RemoveIfContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key)
    {
        if (@this.ContainsKey(key)) @this.Remove(key);
    }
}