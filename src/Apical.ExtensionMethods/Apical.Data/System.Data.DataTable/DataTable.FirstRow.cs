#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     A DataTable extension method that return the first row.
    /// </summary>
    /// <param name="this">The table to act on.</param>
    /// <returns>The first row of the table.</returns>
    public static DataRow FirstRow(this DataTable @this)
    {
        return @this.Rows[0];
    }
}