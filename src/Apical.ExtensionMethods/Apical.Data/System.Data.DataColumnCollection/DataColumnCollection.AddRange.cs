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
    ///     A DataColumnCollection extension method that adds a range to 'columns'.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columns">A variable-length parameters list containing columns.</param>
    public static void AddRange(this DataColumnCollection @this, params string[] columns)
    {
        foreach (var column in columns) @this.Add(column);
    }
}