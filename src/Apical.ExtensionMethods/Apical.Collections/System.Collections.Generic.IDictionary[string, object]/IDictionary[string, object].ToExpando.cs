#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.Dynamic;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     An IDictionary&lt;string,object&gt; extension method that converts the @this to an expando.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>@this as an ExpandoObject.</returns>
    public static ExpandoObject ToExpando(this IDictionary<string, object> @this)
    {
        var expando = new ExpandoObject();
        var expandoDict = (IDictionary<string, object>)expando;

        foreach (var item in @this)
            if (item.Value is IDictionary<string, object>)
            {
                var d = (IDictionary<string, object>)item.Value;
                expandoDict.Add(item.Key, d.ToExpando());
            }
            else
            {
                expandoDict.Add(item);
            }

        return expando;
    }
}