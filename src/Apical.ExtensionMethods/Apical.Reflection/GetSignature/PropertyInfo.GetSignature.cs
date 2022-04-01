#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A PropertyInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this PropertyInfo @this)
    {
        // Example: [Name | Indexer[Type]]

        var indexerParameter = @this.GetIndexParameters();
        if (indexerParameter.Length == 0)
            // Name
            return @this.Name;
        var sb = new StringBuilder();

        // Indexer
        sb.Append(@this.Name);
        sb.Append("[");
        sb.Append(string.Join(", ", indexerParameter.Select(x => x.ParameterType.GetShortSignature())));
        sb.Append("]");

        return sb.ToString();
    }
}