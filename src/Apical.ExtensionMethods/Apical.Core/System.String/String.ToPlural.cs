#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

#if !NETSTANDARD
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A string extension method that converts the @this to a plural.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToPlural(this string @this)
    {
        return PluralizationService.CreateService(new CultureInfo("en-US")).Pluralize(@this);
    }

    /// <summary>
    ///     A string extension method that converts the @this to a plural.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cultureInfo">Information describing the culture.</param>
    /// <returns>@this as a string.</returns>
    public static string ToPlural(this string @this, CultureInfo cultureInfo)
    {
        return PluralizationService.CreateService(cultureInfo).Pluralize(@this);
    }
#endif
}