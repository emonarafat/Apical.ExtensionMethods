#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Data;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A T[] extension method that converts the @this to a data table.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DataTable.</returns>
    public static DataTable ToDataTable<T>(this T[] @this)
    {
        var type = typeof(T);

        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var dt = new DataTable();

        foreach (var property in properties) dt.Columns.Add(property.Name, property.PropertyType);

        foreach (var field in fields) dt.Columns.Add(field.Name, field.FieldType);

        foreach (var item in @this)
        {
            var dr = dt.NewRow();

            foreach (var property in properties) dr[property.Name] = property.GetValue(item, null);

            foreach (var field in fields) dr[field.Name] = field.GetValue(item);

            dt.Rows.Add(dr);
        }

        return dt;
    }
}