#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright ? Apical Automates Inc. All rights reserved.

#endregion

using System.Text;

public static partial class Extensions
{
    /// <summary>A string extension method that strip HTML.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string StripHtml(this string @this)
    {
        var path = new StringBuilder(@this);
        var sb = new StringBuilder();

        var pos = 0;

        while (pos < path.Length)
        {
            var ch = path[pos];
            pos++;

            if (ch == '<')
                // LOOP until we close the html tag
                while (pos < path.Length)
                {
                    ch = path[pos];
                    pos++;

                    if (ch == '>') break;

                    if (ch == '\'')
                        // SKIP attribute starting with single quote
                        pos = GetIndexAfterNextSingleQuote(path, pos, true);
                    else if (ch == '"')
                        // SKIP attribute starting with double quote
                        pos = GetIndexAfterNextDoubleQuote(path, pos, true);
                }
            else
                sb.Append(ch);
        }

        return sb.ToString();
    }
}