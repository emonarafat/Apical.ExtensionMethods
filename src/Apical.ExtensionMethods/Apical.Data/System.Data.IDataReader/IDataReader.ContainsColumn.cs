#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that query if '@this' contains column.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnIndex">Zero-based index of the column.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsColumn(this IDataReader @this, int columnIndex)
    {
        try
        {
            // Check if FieldCount is implemented first
            return @this.FieldCount > columnIndex;
        }
        catch (Exception)
        {
            try
            {
                return @this[columnIndex] != null;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    /// <summary>
    ///     An IDataReader extension method that query if '@this' contains column.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsColumn(this IDataReader @this, string columnName)
    {
        try
        {
            // Check if GetOrdinal is implemented first
            return @this.GetOrdinal(columnName) != -1;
        }
        catch (Exception)
        {
            try
            {
                return @this[columnName] != null;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}