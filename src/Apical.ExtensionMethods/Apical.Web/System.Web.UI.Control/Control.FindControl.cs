#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

#if !NETSTANDARD
using System.Web.UI;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     Searches the current naming container for a server control with the specified id parameter.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="id">The identifier for the control to be found.</param>
    /// <returns>The specified control, or a null reference if the specified control does not exist.</returns>
    public static T FindControl<T>(this Control @this, string id) where T : class
    {
        return (@this.FindControl(id) as T);
    }
#endif
}