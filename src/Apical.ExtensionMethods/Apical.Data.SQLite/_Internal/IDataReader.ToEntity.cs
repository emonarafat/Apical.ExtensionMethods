#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Apical.Data.SQLite._Internal
{
    internal static partial class Extensions
    {
        /// <summary>
        ///     An IDataReader extension method that converts the @this to an entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a T.</returns>
        public static T ToEntity<T>(this IDataReader @this) where T : new()
        {
            var type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var entity = new T();

            var hash = new HashSet<string>(Enumerable.Range(0, @this.FieldCount)
                .Select(@this.GetName));

            foreach (var property in properties)
                if (hash.Contains(property.Name))
                {
                    var valueType = property.PropertyType;
                    property.SetValue(entity, @this[property.Name].To(valueType), null);
                }

            foreach (var field in fields)
                if (hash.Contains(field.Name))
                {
                    var valueType = field.FieldType;
                    field.SetValue(entity, @this[field.Name].To(valueType));
                }

            return entity;
        }
    }
}