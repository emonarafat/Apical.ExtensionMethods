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
    ///     Deserializes a 64-bit binary value and recreates an original serialized  object.
    /// </summary>
    /// <param name="dateData">The dateData<see cref="Int64" />.</param>
    /// <returns>An object that is equivalent to the  object that was serialized by the  method.</returns>
    public static DateTime FromBinary(this long dateData)
    {
        return DateTime.FromBinary(dateData);
    }
}