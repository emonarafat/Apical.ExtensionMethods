#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.ComponentModel;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A System.Object extension method that toes the given this.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <returns>A T.</returns>
    public static T To<T>(this object @this)
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

    /// <summary>
    ///     A System.Object extension method that toes the given this.
    /// </summary>
    /// <param name="this">this.</param>
    /// <param name="type">The type.</param>
    /// <returns>An object.</returns>
    public static object To(this object @this, Type type)
    {
        if (@this != null)
        {
            var targetType = type;

            if (@this.GetType() == targetType) return @this;

            var converter = TypeDescriptor.GetConverter(@this);
            if (converter != null)
                if (converter.CanConvertTo(targetType))
                    return converter.ConvertTo(@this, targetType);

            converter = TypeDescriptor.GetConverter(targetType);
            if (converter != null)
                if (converter.CanConvertFrom(@this.GetType()))
                    return converter.ConvertFrom(@this);

            if (@this == DBNull.Value) return null;
        }

        return @this;
    }
}