#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.Data;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     Enumerates to entities in this collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an IEnumerable&lt;T&gt;</returns>
    public static IEnumerable<T> ToEntities<T>(this DataTable @this) where T : new()
    {
        var type = typeof(T);
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var list = new List<T>();

        foreach (DataRow dr in @this.Rows)
        {
            var entity = new T();

            foreach (var property in properties)
                if (@this.Columns.Contains(property.Name))
                {
                    var valueType = property.PropertyType;
                    property.SetValue(entity, dr[property.Name].To(valueType), null);
                }

            foreach (var field in fields)
                if (@this.Columns.Contains(field.Name))
                {
                    var valueType = field.FieldType;
                    field.SetValue(entity, dr[field.Name].To(valueType));
                }

            list.Add(entity);
        }

        return list;
    }
}