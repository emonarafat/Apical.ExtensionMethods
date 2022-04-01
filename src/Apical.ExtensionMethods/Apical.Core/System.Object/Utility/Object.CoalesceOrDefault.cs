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
    ///     A T extension method that that return the first not null value (including the @this) or a default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>The first not null value or a default value.</returns>
    public static T CoalesceOrDefault<T>(this T @this, Func<T, T> defaultValueFactory, params T[] values)
        where T : class
    {
        if (@this != null) return @this;

        foreach (var value in values)
            if (value != null)
                return value;

        return defaultValueFactory(@this);
    }

    /// <summary>
    ///     A T extension method that that return the first not null value (including the @this) or a default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>The first not null value or a default value.</returns>
    public static T CoalesceOrDefault<T>(this T @this, Func<T> defaultValueFactory, params T[] values) where T : class
    {
        if (@this != null) return @this;

        foreach (var value in values)
            if (value != null)
                return value;

        return defaultValueFactory();
    }

    /// <summary>
    ///     A T extension method that that return the first not null value (including the @this) or a default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>The first not null value or a default value.</returns>
    public static T CoalesceOrDefault<T>(this T @this, params T[] values) where T : class
    {
        if (@this != null) return @this;

        foreach (var value in values)
            if (value != null)
                return value;

        return default;
    }
}