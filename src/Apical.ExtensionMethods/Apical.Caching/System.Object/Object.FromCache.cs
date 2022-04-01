#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Linq.Expressions;
using System.Runtime.Caching;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     The FromCache.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cache">The cache.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key,
        Expression<Func<T, TValue>> valueFactory)
    {
        var lazy = new Lazy<TValue>(() => valueFactory.Compile()(@this));
        var item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;
        return item.Value;
    }

    /// <summary>
    ///     The FromCache.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cache">The cache.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, TValue value)
    {
        var item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;

        return (TValue)item;
    }

    /// <summary>
    ///     The FromCache.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<T, TValue>(this T @this, string key, Expression<Func<T, TValue>> valueFactory)
    {
        return @this.FromCache(MemoryCache.Default, key, valueFactory);
    }

    /// <summary>
    ///     The FromCache.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<T, TValue>(this T @this, string key, TValue value)
    {
        return @this.FromCache(MemoryCache.Default, key, value);
    }

    /// <summary>
    ///     The FromCache.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<TKey, TValue>(this TKey @this, Expression<Func<TKey, TValue>> valueFactory)
    {
        var key = string.Concat("Z.Caching.FromCache;", typeof(TKey).FullName, valueFactory.ToString());
        return @this.FromCache(MemoryCache.Default, key, valueFactory);
    }

    /// <summary>
    ///     The FromCache.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="cache">The cache.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<TKey, TValue>(this TKey @this, MemoryCache cache,
        Expression<Func<TKey, TValue>> valueFactory)
    {
        var key = string.Concat("Z.Caching.FromCache;", typeof(TKey).FullName, valueFactory.ToString());
        return @this.FromCache(cache, key, valueFactory);
    }
}