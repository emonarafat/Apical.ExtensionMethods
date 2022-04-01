#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that gets value as.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <returns>The value as.</returns>
    public static T GetValueAs<T>(this IDataReader @this, int index)
    {
        return (T)@this.GetValue(index);
    }

    /// <summary>
    ///     An IDataReader extension method that gets value as.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <returns>The value as.</returns>
    public static T GetValueAs<T>(this IDataReader @this, string columnName)
    {
        return (T)@this.GetValue(@this.GetOrdinal(columnName));
    }
}