#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.Data;
using System.Dynamic;

public static partial class Extensions
{
    /// <summary>A DataRow extension method that converts the @this to an expando object.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a dynamic.</returns>
    public static dynamic ToExpandoObject(this DataRow @this)
    {
        dynamic entity = new ExpandoObject();
        var expandoDict = (IDictionary<string, object>)entity;

        foreach (DataColumn column in @this.Table.Columns) expandoDict.Add(column.ColumnName, @this[column]);

        return expandoDict;
    }
}