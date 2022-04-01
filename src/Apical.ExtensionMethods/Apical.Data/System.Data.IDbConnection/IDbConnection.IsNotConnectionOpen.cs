#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>A DbConnection extension method that queries if a not connection is open.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if a not connection is open, false if not.</returns>
    public static bool IsNotConnectionOpen(this DbConnection @this)
    {
        return @this.State != ConnectionState.Open;
    }
}