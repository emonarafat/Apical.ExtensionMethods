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
    ///     An object extension method that converts this object to a string or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToStringOrDefault(this object @this)
    {
        try
        {
            return Convert.ToString(@this);
        }
        catch (Exception)
        {
            return default;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a string or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToStringOrDefault(this object @this, Func<string> defaultValueFactory)
    {
        try
        {
            return Convert.ToString(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a string or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToStringOrDefault(this object @this, Func<string> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null) return defaultValueFactory();

        try
        {
            return Convert.ToString(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a string or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToStringOrDefault(this object @this, string defaultValue)
    {
        try
        {
            return Convert.ToString(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a string or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToStringOrDefault(this object @this, string defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null) return defaultValue;

        try
        {
            return Convert.ToString(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }
}