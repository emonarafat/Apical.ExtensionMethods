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
    /// <summary>A DataTable extension method that last row.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DataRow.</returns>
    public static DataRow LastRow(this DataTable @this)
    {
        return @this.Rows[@this.Rows.Count - 1];
    }
}