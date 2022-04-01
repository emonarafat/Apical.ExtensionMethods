#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A ParameterInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this ParameterInfo @this)
    {
        var sb = new StringBuilder();

        @this.GetSignature(sb);
        return sb.ToString();
    }

    internal static void GetSignature(this ParameterInfo @this, StringBuilder sb)
    {
        // retval attribute

        string typeName;
        var elementType = @this.ParameterType.GetElementType();

        if (elementType != null)
            typeName = @this.ParameterType.Name.Replace(elementType.Name, elementType.GetShortSignature());
        else
            typeName = @this.ParameterType.GetShortSignature();

        if (@this.IsOut)
        {
            if (typeName.Contains("&"))
            {
                typeName = typeName.Replace("&", "");
                sb.Append("out ");
            }
        }
        else if (@this.ParameterType.IsByRef)
        {
            typeName = typeName.Replace("&", "");
            sb.Append("ref ");
        }

        sb.Append(typeName);
    }
}