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
    /// <summary>An object extension method that gets the properties.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An array of property information.</returns>
    public static PropertyInfo[] GetProperties(this object @this)
    {
        return @this.GetType().GetProperties();
    }

    /// <summary>An object extension method that gets the properties.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="bindingAttr">The binding attribute.</param>
    /// <returns>An array of property information.</returns>
    public static PropertyInfo[] GetProperties(this object @this, BindingFlags bindingAttr)
    {
        return @this.GetType().GetProperties(bindingAttr);
    }
}