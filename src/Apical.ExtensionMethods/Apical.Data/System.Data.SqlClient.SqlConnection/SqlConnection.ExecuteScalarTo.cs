#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright � Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Data;
using System.Data.SqlClient;

public static partial class Extensions
{
    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters,
        CommandType commandType, SqlTransaction transaction)
    {
        using var command = @this.CreateCommand();
        command.CommandText = cmdText;
        command.CommandType = commandType;
        command.Transaction = transaction;

        if (parameters != null) command.Parameters.AddRange(parameters);

        return command.ExecuteScalar().To<T>();
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, Action<SqlCommand> commandFactory)
    {
        using var command = @this.CreateCommand();
        commandFactory(command);

        return command.ExecuteScalar().To<T>();
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, string cmdText)
    {
        return @this.ExecuteScalarTo<T>(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, string cmdText, SqlTransaction transaction)
    {
        return @this.ExecuteScalarTo<T>(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, string cmdText, CommandType commandType)
    {
        return @this.ExecuteScalarTo<T>(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, string cmdText, CommandType commandType,
        SqlTransaction transaction)
    {
        return @this.ExecuteScalarTo<T>(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters)
    {
        return @this.ExecuteScalarTo<T>(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters,
        SqlTransaction transaction)
    {
        return @this.ExecuteScalarTo<T>(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters,
        CommandType commandType)
    {
        return @this.ExecuteScalarTo<T>(cmdText, parameters, commandType, null);
    }
}