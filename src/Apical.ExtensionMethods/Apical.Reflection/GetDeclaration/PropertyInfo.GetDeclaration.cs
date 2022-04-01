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
    /// <summary>A PropertyInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetDeclaraction(this PropertyInfo @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name | Indexer] { [VisibilityGetter] [Getter]; [VisibilitySetter] [Setter]; }
        var sb = new StringBuilder();

        // Variable
        var canRead = @this.CanRead;
        var canWrite = @this.CanWrite;
        var readLevel = 9;
        var writeLevel = 9;
        var readVisibility = "";
        var writeVisibility = "";

        // Variable Method
        var isAbstract = false;
        var isOverride = false;
        var isStatic = false;
        var isVirtual = false;

        // Set visibility
        if (canRead)
        {
            var method = @this.GetGetMethod(true);
            isAbstract = method.IsAbstract;
            isOverride = method.GetBaseDefinition().DeclaringType != method.DeclaringType;
            isStatic = method.IsStatic;
            isVirtual = method.IsVirtual;

            if (method.IsPublic)
            {
                readLevel = 1;
                readVisibility = "public ";
            }
            else if (method.IsFamily)
            {
                readLevel = 2;
                readVisibility = "protected ";
            }
            else if (method.IsAssembly)
            {
                readLevel = 3;
                readVisibility = "internal ";
            }
            else if (method.IsPrivate)
            {
                readLevel = 5;
                readVisibility = "private ";
            }
            else
            {
                readLevel = 4;
                readVisibility = "protected internal ";
            }
        }

        if (canWrite)
        {
            var method = @this.GetSetMethod(true);

            if (readLevel != 9)
            {
                isAbstract = method.IsAbstract;
                isOverride = method.GetBaseDefinition().DeclaringType != method.DeclaringType;
                isStatic = method.IsStatic;
                isVirtual = method.IsVirtual;
            }

            if (method.IsPublic)
            {
                writeLevel = 1;
                writeVisibility = "public ";
            }
            else if (method.IsFamily)
            {
                writeLevel = 2;
                writeVisibility = "protected ";
            }
            else if (method.IsAssembly)
            {
                writeLevel = 3;
                writeVisibility = "internal ";
            }
            else if (method.IsPrivate)
            {
                writeLevel = 5;
                writeVisibility = "private ";
            }
            else
            {
                writeLevel = 4;
                writeVisibility = "protected internal ";
            }
        }

        // Visibility
        if (canRead && canWrite)
            sb.Append(readLevel <= writeLevel ? readVisibility : writeVisibility);
        else if (canRead)
            sb.Append(readVisibility);
        else
            sb.Append(writeVisibility);

        // Modifier
        if (isAbstract)
            sb.Append("abstract ");
        else if (isOverride)
            sb.Append("override ");
        else if (isVirtual)
            sb.Append("virtual ");
        else if (isStatic) sb.Append("static ");

        // Type
        sb.Append(@this.PropertyType.GetShortDeclaraction());
        sb.Append(" ");

        // [Name | Indexer]
        var indexerParameter = @this.GetIndexParameters();
        if (indexerParameter.Length == 0)
        {
            // Name
            sb.Append(@this.Name);
        }
        else
        {
            // Indexer
            sb.Append("this");
            sb.Append("[");
            sb.Append(string.Join(", ",
                indexerParameter.Select(x => x.ParameterType.GetShortDeclaraction() + " " + x.Name)));
            sb.Append("]");
        }

        sb.Append(" ");

        sb.Append("{ ");
        // Getter
        if (@this.CanRead)
        {
            if (readLevel > writeLevel) sb.Append(readVisibility);
            sb.Append("get; ");
        }

        // Setter
        if (@this.CanWrite)
        {
            if (writeLevel > readLevel) sb.Append(writeVisibility);
            sb.Append("set; ");
        }

        sb.Append("}");

        return sb.ToString();
    }
}