#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A Type extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this Type @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments>] [:] [Inherited Class] [Inherited Interface]
        var sb = new StringBuilder();

        // Variable
        var hasInheritedClass = false;

        // Name
        sb.Append(@this.IsGenericType ? @this.Name.Substring(0, @this.Name.IndexOf('`')) : @this.Name);

        // GenericArguments
        if (@this.IsGenericType)
        {
            var arguments = @this.GetGenericArguments();
            sb.Append("<");
            sb.Append(string.Join(", ", arguments.Select(x =>
            {
                var constraints = x.GetGenericParameterConstraints();

                foreach (var constraint in constraints)
                {
                    var gpa = constraint.GenericParameterAttributes;
                    var variance = gpa & GenericParameterAttributes.VarianceMask;

                    if (variance != GenericParameterAttributes.None)
                        sb.Append((variance & GenericParameterAttributes.Covariant) != 0 ? "in " : "out ");
                }

                return x.GetShortDeclaraction();
            })));
            sb.Append(">");
        }

        return sb.ToString();
    }
}