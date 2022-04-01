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
    /// <summary>
    ///     Determines whether any custom attributes are applied to a member of a type. Parameters specify the member,
    ///     and the type of the custom attribute to search for.
    /// </summary>
    /// <param name="element">
    ///     An object derived from the  class that describes a constructor, event, field, method, type,
    ///     or property member of a class.
    /// </param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
    public static bool IsDefined(this MemberInfo element, Type attributeType)
    {
        return Attribute.IsDefined(element, attributeType);
    }

    /// <summary>
    ///     Determines whether any custom attributes are applied to a member of a type. Parameters specify the member,
    ///     the type of the custom attribute to search for, and whether to search ancestors of the member.
    /// </summary>
    /// <param name="element">
    ///     An object derived from the  class that describes a constructor, event, field, method, type,
    ///     or property member of a class.
    /// </param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
    /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
    public static bool IsDefined(this MemberInfo element, Type attributeType, bool inherit)
    {
        return Attribute.IsDefined(element, attributeType, inherit);
    }
}