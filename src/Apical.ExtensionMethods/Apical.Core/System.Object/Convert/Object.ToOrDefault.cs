#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.ComponentModel;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A System.Object extension method that converts this object to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <returns>The given data converted to a T.</returns>
    public static T ToOrDefault<T>(this object @this)
    {
        return @this.ToOrDefault(x => default(T));
    }

    /// <summary>
    ///     A System.Object extension method that converts this object to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a T.</returns>
    public static T ToOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
    {
        try
        {
            if (@this != null)
            {
                var targetType = typeof(T);

                if (@this.GetType() == targetType) return (T)@this;

                var converter = TypeDescriptor.GetConverter(@this);
                if (converter != null)
                    if (converter.CanConvertTo(targetType))
                        return (T)converter.ConvertTo(@this, targetType);

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null)
                    if (converter.CanConvertFrom(@this.GetType()))
                        return (T)converter.ConvertFrom(@this);

                if (@this == DBNull.Value) return (T)(object)null;
            }

            return (T)@this;
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }

    /// <summary>
    ///     A System.Object extension method that converts this object to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a T.</returns>
    public static T ToOrDefault<T>(this object @this, Func<T> defaultValueFactory)
    {
        return @this.ToOrDefault(x => defaultValueFactory());
    }

    /// <summary>
    ///     A System.Object extension method that converts this object to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a T.</returns>
    public static T ToOrDefault<T>(this object @this, T defaultValue)
    {
        return @this.ToOrDefault(x => defaultValue);
    }
}