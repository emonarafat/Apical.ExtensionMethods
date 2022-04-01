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
    ///     A bool extension method that execute an Action if the value is true.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <param name="action">The action to execute.</param>
    public static void IfTrue(this bool @this, Action action)
    {
        if (@this) action();
    }
}