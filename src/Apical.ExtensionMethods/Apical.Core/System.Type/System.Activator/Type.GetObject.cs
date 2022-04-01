#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     Creates a proxy for the well-known object indicated by the specified type and URL.
    /// </summary>
    /// <param name="type">The type of the well-known object to which you want to connect.</param>
    /// <param name="url">The URL of the well-known object.</param>
    /// <returns>A proxy that points to an endpoint served by the requested well-known object.</returns>
    public static Object GetObject(this Type type, String url)
    {
        return Activator.GetObject(type, url);
    }

    /// <summary>
    ///     Creates a proxy for the well-known object indicated by the specified type, URL, and channel data.
    /// </summary>
    /// <param name="type">The type of the well-known object to which you want to connect.</param>
    /// <param name="url">The URL of the well-known object.</param>
    /// <param name="state">Channel-specific data or null.</param>
    /// <returns>A proxy that points to an endpoint served by the requested well-known object.</returns>
    public static Object GetObject(this Type type, String url, Object state)
    {
        return Activator.GetObject(type, url, state);
    }
#endif
}