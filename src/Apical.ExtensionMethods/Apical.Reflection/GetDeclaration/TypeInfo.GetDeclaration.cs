#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A Type extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetDeclaraction(this Type @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments>] [:] [Inherited Class] [Inherited Interface]
        var sb = new StringBuilder();

        // Variable
        var hasInheritedClass = false;

        // Visibility
        sb.Append(@this.IsPublic ? "public " : "internal ");

        // Modifier
        if (!@this.IsInterface && @this.IsAbstract) sb.Append(@this.IsSealed ? "static " : "abstract ");

        // Type
        sb.Append(@this.IsInterface ? "interface " : "class ");

        // Name
        sb.Append(@this.IsGenericType ? @this.Name.Substring(0, @this.Name.IndexOf('`')) : @this.Name);

        var constraintType = new List<string>();

        // GenericArguments
        if (@this.IsGenericType)
        {
            var arguments = @this.GetGenericArguments();
            sb.Append("<");
            sb.Append(string.Join(", ", arguments.Select(x =>
            {
                var sConstraints = x.GenericParameterAttributes;

                if (GenericParameterAttributes.None != (sConstraints & GenericParameterAttributes.Contravariant))
                    sb.Append("in ");
                if (GenericParameterAttributes.None != (sConstraints & GenericParameterAttributes.Covariant))
                    sb.Append("out ");

                var parameterConstraint = new List<string>();

                if (GenericParameterAttributes.None !=
                    (sConstraints & GenericParameterAttributes.ReferenceTypeConstraint))
                    parameterConstraint.Add("class");


                if (GenericParameterAttributes.None !=
                    (sConstraints & GenericParameterAttributes.DefaultConstructorConstraint))
                    parameterConstraint.Add("new()");


                if (parameterConstraint.Count > 0)
                    constraintType.Add(x.Name + " : " + string.Join(", ", parameterConstraint));

                return x.GetShortDeclaraction();
            })));
            sb.Append(">");

            foreach (var argument in arguments)
            {
                var sConstraints = argument.GenericParameterAttributes &
                                   GenericParameterAttributes.SpecialConstraintMask;
            }
        }

        var constaints = new List<string>();

        // Inherited Class
        if (@this.BaseType != null && @this.BaseType != typeof(object))
            constaints.Add(@this.BaseType.GetShortDeclaraction());

        // Inherited Interface
        var interfaces = @this.GetInterfaces();
        if (interfaces.Length > 0) constaints.AddRange(interfaces.Select(x => x.Name));

        if (constaints.Count > 0)
        {
            sb.Append(" : ");
            sb.Append(string.Join(", ", constaints));
        }

        if (constraintType.Count > 0)
        {
            sb.Append(" where ");
            sb.Append(string.Join(", ", constraintType));
        }

        return sb.ToString();
    }
}