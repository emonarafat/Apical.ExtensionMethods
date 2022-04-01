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
    ///     An object extension method that converts the @this to a nullable date time off set.
    /// </summary>
    /// <param name="this">The this to act on.</param>
    /// <returns>@this as a DateTimeOffset?.</returns>
    public static DateTimeOffset? ToNullableDateTimeOffSet(this object @this)
    {
        if (@this == null || @this == DBNull.Value) return null;

        return new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
    }
}