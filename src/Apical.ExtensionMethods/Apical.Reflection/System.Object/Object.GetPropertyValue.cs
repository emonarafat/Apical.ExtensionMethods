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
    ///     A T extension method that gets property value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="propertyName">Name of the property.</param>
    /// <returns>The property value.</returns>
    public static object GetPropertyValue<T>(this T @this, string propertyName)
    {
        var type = @this.GetType();
        var property = type.GetProperty(propertyName,
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

        return property.GetValue(@this, null);
    }
}