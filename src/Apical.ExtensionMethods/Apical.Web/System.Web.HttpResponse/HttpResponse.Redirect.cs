#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

#if !NETSTANDARD
using System.Web;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A HttpResponse extension method that redirects.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="urlFormat">The URL format.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    public static void Redirect(this HttpResponse @this, string urlFormat, params object[] values)
    {
        string url = string.Format(urlFormat, values);
        @this.Redirect(url, true);
    }
#endif
}