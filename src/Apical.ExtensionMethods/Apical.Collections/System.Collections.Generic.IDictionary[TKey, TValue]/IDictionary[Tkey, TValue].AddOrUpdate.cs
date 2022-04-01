#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Collections.Generic;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does
    ///     not already exist, or to update a key/value pair in the IDictionary&lt;TKey, TValue&gt;> if the key already
    ///     exists.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="key">The key to be added or whose value should be updated.</param>
    /// <param name="addValueFactory">The function used to generate a value for an absent key.</param>
    /// <param name="updateValueFactory">The updateValueFactory<see cref="Func{TKey, TValue, TValue}" />.</param>
    /// <returns>The <see cref="T:TValue" />.</returns>
    public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key,
        Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
    {
        if (!@this.ContainsKey(key))
            @this.Add(new KeyValuePair<TKey, TValue>(key, addValueFactory(key)));
        else
            @this[key] = updateValueFactory(key, @this[key]);

        return @this[key];
    }

    /// <summary>
    ///     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does
    ///     not already exist, or to update a key/value pair in the IDictionary&lt;TKey, TValue&gt;> if the key already
    ///     exists.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="key">The key to be added or whose value should be updated.</param>
    /// <param name="addValue">The value to be added for an absent key.</param>
    /// <param name="updateValueFactory">The updateValueFactory<see cref="Func{TKey, TValue, TValue}" />.</param>
    /// <returns>The <see cref="T:TValue" />.</returns>
    public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue addValue,
        Func<TKey, TValue, TValue> updateValueFactory)
    {
        if (!@this.ContainsKey(key))
            @this.Add(new KeyValuePair<TKey, TValue>(key, addValue));
        else
            @this[key] = updateValueFactory(key, @this[key]);

        return @this[key];
    }

    /// <summary>
    ///     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does
    ///     not already exist, or to update a key/value pair in the IDictionary&lt;TKey, TValue&gt;> if the key already
    ///     exists.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="key">The key to be added or whose value should be updated.</param>
    /// <param name="value">The value to be added or updated.</param>
    /// <returns>The new value for the key.</returns>
    public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
    {
        if (!@this.ContainsKey(key))
            @this.Add(new KeyValuePair<TKey, TValue>(key, value));
        else
            @this[key] = value;

        return @this[key];
    }
}