#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Collections.Generic;
using System.Collections.Specialized;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     A NameValueCollection extension method that converts the @this to a dictionary.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>@this as an IDictionary&lt;string,object&gt;.</returns>
    public static IDictionary<string, object> ToDictionary(this NameValueCollection @this)
    {
        var dict = new Dictionary<string, object>();

        if (@this != null)
            foreach (var key in @this.AllKeys)
                dict.Add(key, @this[key]);

        return dict;
    }
}