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
    ///     A HttpResponse extension method that sets the response to status code 204 (No content.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusNoContent(this HttpResponse @this)
    {
        @this.StatusCode = 204;
        @this.StatusDescription = "No content.";
    }
#endif
}