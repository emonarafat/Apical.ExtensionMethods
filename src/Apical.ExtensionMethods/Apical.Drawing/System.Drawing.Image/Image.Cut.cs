#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

#if !NETSTANDARD
using System.Drawing;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     An Image extension method that cuts an image.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="width">The width.</param>
    /// <param name="height">The height.</param>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    /// <returns>The cutted image.</returns>
    public static Image Cut(this Image @this, int width, int height, int x, int y)
    {
        var r = new Bitmap(width, height);
        var destinationRectange = new Rectangle(0, 0, width, height);
        var sourceRectangle = new Rectangle(x, y, width, height);

        using (Graphics g = Graphics.FromImage(r))
        {
            g.DrawImage(@this, destinationRectange, sourceRectangle, GraphicsUnit.Pixel);
        }

        return r;
    }
#endif
}