#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that converts the @this to a data table.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DataTable.</returns>
    public static DataTable ToDataTable(this IDataReader @this)
    {
        var dt = new DataTable();
        dt.Load(@this);
        return dt;
    }
}