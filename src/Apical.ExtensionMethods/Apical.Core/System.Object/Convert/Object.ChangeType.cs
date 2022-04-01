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
    ///     Returns an object of the specified type and whose value is equivalent to the specified object.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">An object that implements the  interface.</param>
    /// <returns>The <see cref="object" />.</returns>
    public static object ChangeType<T>(this object value)
    {
        return (T)Convert.ChangeType(value, typeof(T));
    }

    /// <summary>
    ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
    ///     supplies culture-specific formatting information.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>The <see cref="Object" />.</returns>
    public static object ChangeType<T>(this object value, IFormatProvider provider)
    {
        return (T)Convert.ChangeType(value, typeof(T), provider);
    }

    /// <summary>
    ///     Returns an object of the specified type and whose value is equivalent to the specified object.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="conversionType">The type of object to return.</param>
    /// <returns>The <see cref="Object" />.</returns>
    public static object ChangeType(this object value, Type conversionType)
    {
        return Convert.ChangeType(value, conversionType);
    }

    /// <summary>
    ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
    ///     supplies culture-specific formatting information.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="conversionType">The type of object to return.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>The <see cref="Object" />.</returns>
    public static object ChangeType(this object value, Type conversionType, IFormatProvider provider)
    {
        return Convert.ChangeType(value, conversionType, provider);
    }

    /// <summary>
    ///     Returns an object of the specified type whose value is equivalent to the specified object.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="typeCode">The type of object to return.</param>
    /// <returns>The <see cref="Object" />.</returns>
    public static object ChangeType(this object value, TypeCode typeCode)
    {
        return Convert.ChangeType(value, typeCode);
    }

    /// <summary>
    ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
    ///     supplies culture-specific formatting information.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="typeCode">The type of object to return.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>The <see cref="Object" />.</returns>
    public static object ChangeType(this object value, TypeCode typeCode, IFormatProvider provider)
    {
        return Convert.ChangeType(value, typeCode, provider);
    }
}