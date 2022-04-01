#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

#if !NETSTANDARD
using System.Web;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    public static void SetStatus(this HttpResponse @this, int code)
    {
        @this.StatusCode = code;
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="endResponse">true to end response.</param>
    public static void SetStatus(this HttpResponse @this, int code, bool endResponse)
    {
        @this.StatusCode = code;

        if (endResponse)
        {
            @this.End();
        }
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="description">The description.</param>
    public static void SetStatus(this HttpResponse @this, int code, string description)
    {
        @this.StatusCode = code;
        @this.StatusDescription = description;
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="description">The description.</param>
    /// <param name="endResponse">true to end response.</param>
    public static void SetStatus(this HttpResponse @this, int code, string description, bool endResponse)
    {
        @this.StatusCode = code;
        @this.StatusDescription = description;

        if (endResponse)
        {
            @this.End();
        }
    }
#endif
}