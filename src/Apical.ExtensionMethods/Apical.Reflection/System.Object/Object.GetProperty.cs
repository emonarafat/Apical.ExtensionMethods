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
    ///     A T extension method that gets a property.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <returns>The property.</returns>
    public static PropertyInfo GetProperty<T>(this T @this, string name)
    {
        return @this.GetType().GetProperty(name);
    }

    /// <summary>
    ///     A T extension method that gets a property.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <param name="bindingAttr">The binding attribute.</param>
    /// <returns>The property.</returns>
    public static PropertyInfo GetProperty<T>(this T @this, string name, BindingFlags bindingAttr)
    {
        return @this.GetType().GetProperty(name, bindingAttr);
    }
}