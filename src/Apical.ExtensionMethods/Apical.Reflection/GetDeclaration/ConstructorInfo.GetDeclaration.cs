#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    public static string GetDeclaraction(this ConstructorInfo @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
        var sb = new StringBuilder();

        // Visibility
        if (@this.IsPublic)
            sb.Append("public ");
        else if (@this.IsFamily)
            sb.Append("protected ");
        else if (@this.IsAssembly)
            sb.Append("internal ");
        else if (@this.IsPrivate)
            sb.Append("private ");
        else
            sb.Append("protected internal ");

        // Name
        sb.Append(@this.ReflectedType.IsGenericType
            ? @this.ReflectedType.Name.Substring(0, @this.ReflectedType.Name.IndexOf('`'))
            : @this.ReflectedType.Name);

        // Parameters
        var parameters = @this.GetParameters();
        sb.Append("(");
        sb.Append(string.Join(", ", parameters.Select(x => x.GetDeclaraction())));
        sb.Append(")");

        return sb.ToString();
    }
}