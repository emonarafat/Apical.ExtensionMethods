#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

using System.Data.SqlClient;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A SqlBulkCopy extension method that gets a connection.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The connection.</returns>
    public static SqlConnection GetConnection(this SqlBulkCopy @this)
    {
        var type = @this.GetType();
        var field = type.GetField("_connection", BindingFlags.NonPublic | BindingFlags.Instance);
// ReSharper disable PossibleNullReferenceException
        return field.GetValue(@this) as SqlConnection;
// ReSharper restore PossibleNullReferenceException
    }
}