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
    ///     Returns the  for the specified object.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <returns>The  for , or  if  is null.</returns>
    public static TypeCode GetTypeCode(this object value)
    {
        return Convert.GetTypeCode(value);
    }
}