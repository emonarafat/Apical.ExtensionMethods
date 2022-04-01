#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Runtime.Caching;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     The AddOrGetExisting.
    /// </summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="cache">The cache to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));

        var item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;

        return item.Value;
    }

    /// <summary>
    ///     The AddOrGetExisting.
    /// </summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="cache">The cache to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <param name="policy">The policy.</param>
    /// <param name="regionName">(Optional) name of the region.</param>
    /// <returns>A TValue.</returns>
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory,
        CacheItemPolicy policy, string regionName = null)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));

        var item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, policy, regionName) ?? lazy;

        return item.Value;
    }

    /// <summary>
    ///     The AddOrGetExisting.
    /// </summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="cache">The cache to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <param name="absoluteExpiration">The policy.</param>
    /// <param name="regionName">(Optional) name of the region.</param>
    /// <returns>A TValue.</returns>
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory,
        DateTimeOffset absoluteExpiration, string regionName = null)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));

        var item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, absoluteExpiration, regionName) ?? lazy;

        return item.Value;
    }

    /// <summary>
    ///     The AddOrGetExisting.
    /// </summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="cache">The cache to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>A TValue.</returns>
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, TValue value)
    {
        var item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;

        return (TValue)item;
    }
}