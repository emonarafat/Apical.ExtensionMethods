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
    ///     Removes the last occurrence of the invocation list of a delegate from the invocation list of another delegate.
    /// </summary>
    /// <param name="source">The delegate from which to remove the invocation list of .</param>
    /// <param name="value">The delegate that supplies the invocation list to remove from the invocation list of .</param>
    /// <returns>The <see cref="Delegate" />.</returns>
    public static Delegate Remove(this Delegate source, Delegate value)
    {
        return Delegate.Remove(source, value);
    }
}