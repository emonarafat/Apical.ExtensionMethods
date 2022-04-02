#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A StringBuilder extension method that extracts the trivia tokens described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted trivia tokens.</returns>
    public static StringBuilder ExtractTriviaToken(this StringBuilder @this)
    {
        return @this.ExtractTriviaToken(0);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the trivia tokens described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted trivia tokens.</returns>
    public static StringBuilder ExtractTriviaToken(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractTriviaToken(0, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the trivia tokens described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted trivia tokens.</returns>
    public static StringBuilder ExtractTriviaToken(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractTriviaToken(startIndex, out int endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the trivia tokens described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted trivia tokens.</returns>
    public static StringBuilder ExtractTriviaToken(this StringBuilder @this, int startIndex, out int endIndex)
    {
        var sb = new StringBuilder();
        var pos = startIndex;

        var isSpace = false;

        while (pos < @this.Length)
        {
            var ch = @this[pos];
            pos++;

            if (ch == ' ' || ch == '\r' || ch == '\n' || ch == '\t')
            {
                isSpace = true;
                sb.Append(ch);
            }
            else if (ch == '/' && !isSpace)
            {
                if (pos < @this.Length)
                {
                    ch = @this[pos];
                    if (ch == '/') return @this.ExtractCommentSingleLine(startIndex, out endIndex);
                    if (ch == '*') return @this.ExtractCommentMultiLine(startIndex, out endIndex);

                    // otherwise is probably the divide operator
                    pos--;
                    break;
                }
            }
            else
            {
                pos -= 2;
                break;
            }
        }

        if (isSpace)
        {
            endIndex = pos;
            return sb;
        }

        endIndex = -1;
        return null;
    }
}