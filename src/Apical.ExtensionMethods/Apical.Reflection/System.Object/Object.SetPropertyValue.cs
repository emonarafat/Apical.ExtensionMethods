#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that sets property value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="propertyName">Name of the property.</param>
    /// <param name="value">The value.</param>
    public static void SetPropertyValue<T>(this T @this, string propertyName, object value)
    {
        var type = @this.GetType();
        var property = type.GetProperty(propertyName,
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        property.SetValue(@this, value, null);
    }
}