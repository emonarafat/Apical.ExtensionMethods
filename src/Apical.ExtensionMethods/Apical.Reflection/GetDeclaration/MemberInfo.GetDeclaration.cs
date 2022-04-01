#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A MemberInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetDeclaraction(this MemberInfo @this)
    {
        return @this.MemberType switch
        {
            MemberTypes.Field => ((FieldInfo)@this).GetDeclaraction(),
            MemberTypes.Property => ((PropertyInfo)@this).GetDeclaraction(),
            MemberTypes.Constructor => ((ConstructorInfo)@this).GetDeclaraction(),
            MemberTypes.Method => ((MethodInfo)@this).GetDeclaraction(),
            MemberTypes.TypeInfo => ((Type)@this).GetDeclaraction(),
            MemberTypes.NestedType => ((Type)@this).GetDeclaraction(),
            MemberTypes.Event => ((EventInfo)@this).GetDeclaraction(),
            _ => null
        };
    }
}