#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Returns a  equivalent to the specified OLE Automation Date.
    /// </summary>
    /// <param name="d">An OLE Automation Date value.</param>
    /// <returns>An object that represents the same date and time as .</returns>
    public static DateTime FromOADate(this double d)
    {
        return DateTime.FromOADate(d);
    }
}