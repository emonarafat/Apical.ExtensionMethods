#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.IO;
using System.Net;

public static partial class Extensions
{
    /// <summary>
    ///     A WebResponse extension method that reads the response stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The response stream as a string, from the current position to the end.</returns>
    public static string ReadToEnd(this WebResponse @this)
    {
        using var stream = @this.GetResponseStream();
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}