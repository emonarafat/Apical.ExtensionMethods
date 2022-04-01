#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of a specified instance of  to its equivalent binary representation.
    /// </summary>
    /// <param name="d">The value to convert.</param>
    /// <returns>A 32-bit signed integer array with four elements that contain the binary representation of .</returns>
    public static int[] GetBits(this decimal d)
    {
        return decimal.GetBits(d);
    }
}