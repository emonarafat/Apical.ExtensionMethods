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
    ///     An object extension method that converts this object to a nullable u int 32 or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>The given data converted to an uint?.</returns>
    public static uint? ToNullableUInt32OrDefault(this object @this)
    {
        try
        {
            if (@this == null || @this == DBNull.Value) return null;

            return Convert.ToUInt32(@this);
        }
        catch (Exception)
        {
            return default(uint);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable u int 32 or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to an uint?.</returns>
    public static uint? ToNullableUInt32OrDefault(this object @this, Func<uint?> defaultValueFactory)
    {
        try
        {
            if (@this == null || @this == DBNull.Value) return null;

            return Convert.ToUInt32(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable u int 32 or default.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to an uint?.</returns>
    public static uint? ToNullableUInt32OrDefault(this object @this, uint? defaultValue)
    {
        try
        {
            if (@this == null || @this == DBNull.Value) return null;

            return Convert.ToUInt32(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }
}