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
    ///     An IDataReader extension method that query if '@this' is database null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <returns>true if database null, false if not.</returns>
    public static bool IsDBNull(this IDataReader @this, string name)
    {
        return @this.IsDBNull(@this.GetOrdinal(name));
    }
}