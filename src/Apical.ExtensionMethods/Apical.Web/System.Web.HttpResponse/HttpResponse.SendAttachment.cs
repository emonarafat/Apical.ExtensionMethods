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
    ///     A HttpResponse extension method that sends an attachment.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullPathToFile">The full path to file.</param>
    /// <param name="outputFileName">Filename of the output file.</param>
    public static void SendAttachment(this HttpResponse @this, string fullPathToFile, string outputFileName)
    {
        @this.Clear();
        @this.AddHeader("content-disposition", "attachment; filename=" + outputFileName);
        @this.WriteFile(fullPathToFile);
        @this.ContentType = "";
        @this.End();
    }
#endif
}