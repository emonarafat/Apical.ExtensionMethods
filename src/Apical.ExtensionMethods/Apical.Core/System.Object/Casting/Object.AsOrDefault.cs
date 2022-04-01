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
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this)
    {
        try
        {
            return (T)@this;
        }
        catch (Exception)
        {
            return default;
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
    {
        try
        {
            return (T)@this;
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this, Func<T> defaultValueFactory)
    {
        try
        {
            return (T)@this;
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this, T defaultValue)
    {
        try
        {
            return (T)@this;
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }
}