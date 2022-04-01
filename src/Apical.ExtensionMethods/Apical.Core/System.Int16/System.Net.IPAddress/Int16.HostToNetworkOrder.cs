#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Net;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     Converts a short value from host byte order to network byte order.
    /// </summary>
    /// <param name="host">The number to convert, expressed in host byte order.</param>
    /// <returns>A short value, expressed in network byte order.</returns>
    public static short HostToNetworkOrder(this short host)
    {
        return IPAddress.HostToNetworkOrder(host);
    }
}