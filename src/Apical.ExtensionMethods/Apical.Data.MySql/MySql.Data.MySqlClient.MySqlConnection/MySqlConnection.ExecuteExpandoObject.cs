#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Data;
using MySqlConnector;

public static partial class Extensions
{
    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters,
        CommandType commandType, MySqlTransaction transaction)
    {
        using var command = @this.CreateCommand();
        command.CommandText = cmdText;
        command.CommandType = commandType;
        command.Transaction = transaction;

        if (parameters != null) command.Parameters.AddRange(parameters);

        using IDataReader reader = command.ExecuteReader();
        reader.Read();
        return reader.ToExpandoObject();
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, Action<MySqlCommand> commandFactory)
    {
        using var command = @this.CreateCommand();
        commandFactory(command);

        using IDataReader reader = command.ExecuteReader();
        reader.Read();
        return reader.ToExpandoObject();
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, string cmdText)
    {
        return @this.ExecuteExpandoObject(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, string cmdText, MySqlTransaction transaction)
    {
        return @this.ExecuteExpandoObject(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, string cmdText, CommandType commandType)
    {
        return @this.ExecuteExpandoObject(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, string cmdText, CommandType commandType,
        MySqlTransaction transaction)
    {
        return @this.ExecuteExpandoObject(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters)
    {
        return @this.ExecuteExpandoObject(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters,
        MySqlTransaction transaction)
    {
        return @this.ExecuteExpandoObject(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters,
        CommandType commandType)
    {
        return @this.ExecuteExpandoObject(cmdText, parameters, commandType, null);
    }
}