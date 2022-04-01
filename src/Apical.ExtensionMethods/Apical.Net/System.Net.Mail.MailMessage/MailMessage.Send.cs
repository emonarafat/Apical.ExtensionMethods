#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System.Net.Mail;

public static partial class Extensions
{
    /// <summary>
    ///     A MailMessage extension method that send this message.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void Send(this MailMessage @this)
    {
        using var smtpClient = new SmtpClient();
        smtpClient.Send(@this);
    }
}