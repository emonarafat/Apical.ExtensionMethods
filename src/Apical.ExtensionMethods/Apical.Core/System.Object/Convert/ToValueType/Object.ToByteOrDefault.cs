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
    ///     An object extension method that converts this object to a byte or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>The given data converted to a byte.</returns>
    public static byte ToByteOrDefault(this object @this)
    {
        try
        {
            return Convert.ToByte(@this);
        }
        catch (Exception)
        {
            return default;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a byte or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a byte.</returns>
    public static byte ToByteOrDefault(this object @this, byte defaultValue)
    {
        try
        {
            return Convert.ToByte(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     The ToByteOrDefault.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a byte.</returns>
    public static byte ToByteOrDefault(this object @this, byte defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null) return defaultValue;

        try
        {
            return Convert.ToByte(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a byte or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a byte.</returns>
    public static byte ToByteOrDefault(this object @this, Func<byte> defaultValueFactory)
    {
        try
        {
            return Convert.ToByte(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    ///     The ToByteOrDefault.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a byte.</returns>
    public static byte ToByteOrDefault(this object @this, Func<byte> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null) return defaultValueFactory();

        try
        {
            return Convert.ToByte(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}