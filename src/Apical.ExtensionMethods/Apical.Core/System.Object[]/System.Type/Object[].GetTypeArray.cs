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
    ///     Gets the types of the objects in the specified array.
    /// </summary>
    /// <param name="args">An array of objects whose types to determine.</param>
    /// <returns>An array of  objects representing the types of the corresponding elements in .</returns>
    public static Type[] GetTypeArray(this object[] args)
    {
        return Type.GetTypeArray(args);
    }
}