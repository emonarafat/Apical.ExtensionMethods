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
    ///     A T extension method that gets a field value (Public | NonPublic | Instance | Static)
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fieldName">Name of the field.</param>
    /// <returns>The field value.</returns>
    public static object GetFieldValue<T>(this T @this, string fieldName)
    {
        var type = @this.GetType();
        var field = type.GetField(fieldName,
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

        return field.GetValue(@this);
    }
}