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
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="func">The function.</param>
    /// <returns>The value or default.</returns>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return default;
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The value or default.</returns>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func,
        Func<T, TResult> defaultValueFactory)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The value or default.</returns>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func,
        Func<TResult> defaultValueFactory)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The value or default.</returns>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, TResult defaultValue)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }
}