#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

public static partial class Extensions
{
    /// <summary>A FieldInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetDeclaraction(this FieldInfo @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name] [PostModifier];
        var sb = new StringBuilder();

        // Variable
        var isConstant = false;
        var requiredTypes = @this.GetRequiredCustomModifiers();

        // Visibility
        if (@this.IsPublic)
            sb.Append("public ");
        else if (@this.IsPrivate)
            sb.Append("private ");
        else if (@this.IsFamily)
            sb.Append("protected ");
        else if (@this.IsAssembly)
            sb.Append("internal ");
        else
            sb.Append("protected internal ");

        // Modifier
        if (@this.IsStatic)
        {
            if (@this.IsLiteral)
            {
                isConstant = true;
                sb.Append("const ");
            }
            else
            {
                sb.Append("static ");
            }
        }
        else if (@this.IsInitOnly)
        {
            sb.Append("readonly ");
        }

        if (requiredTypes.Any(x => x == typeof(IsVolatile))) sb.Append("volatile ");

        // Type
        sb.Append(@this.FieldType.GetShortDeclaraction());
        sb.Append(" ");

        // Name
        sb.Append(@this.Name);

        // PostModifier
        if (isConstant) sb.Append(" = " + @this.GetRawConstantValue());

        // End
        sb.Append(";");

        return sb.ToString();
    }
}