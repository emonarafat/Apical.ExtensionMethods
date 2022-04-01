#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Data;

/// <summary>
///     Defines the <see cref="Extensions" />.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    ///     The SqlSystemTypeToSqlDbType.
    /// </summary>
    /// <param name="this">The this<see cref="int" />.</param>
    /// <returns>The <see cref="SqlDbType" />.</returns>
    public static SqlDbType SqlSystemTypeToSqlDbType(this int @this)
    {
        return @this switch
        {
            34 => // 34 | "image" | SqlDbType.Image
                SqlDbType.Image,
            35 => // 35 | "text" | SqlDbType.Text
                SqlDbType.Text,
            36 => // 36 | "uniqueidentifier" | SqlDbType.UniqueIdentifier
                SqlDbType.UniqueIdentifier,
            40 => // 40 | "date" | SqlDbType.Date
                SqlDbType.Date,
            41 => // 41 | "time" | SqlDbType.Time
                SqlDbType.Time,
            42 => // 42 | "datetime2" | SqlDbType.DateTime2
                SqlDbType.DateTime2,
            43 => // 43 | "datetimeoffset" | SqlDbType.DateTimeOffset
                SqlDbType.DateTimeOffset,
            48 => // 48 | "tinyint" | SqlDbType.TinyInt
                SqlDbType.TinyInt,
            52 => // 52 | "smallint" | SqlDbType.SmallInt
                SqlDbType.SmallInt,
            56 => // 56 | "int" | SqlDbType.Int
                SqlDbType.Int,
            58 => // 58 | "smalldatetime" | SqlDbType.SmallDateTime
                SqlDbType.SmallDateTime,
            59 => // 59 | "real" | SqlDbType.Real
                SqlDbType.Real,
            60 => // 60 | "money" | SqlDbType.Money
                SqlDbType.Money,
            61 => // 61 | "datetime" | SqlDbType.DateTime
                SqlDbType.DateTime,
            62 => // 62 | "float" | SqlDbType.Float
                SqlDbType.Float,
            98 => // 98 | "sql_variant" | SqlDbType.Variant
                SqlDbType.Variant,
            99 => // 99 | "ntext" | SqlDbType.NText
                SqlDbType.NText,
            104 => // 104 | "bit" | SqlDbType.Bit
                SqlDbType.Bit,
            106 => // 106 | "decimal" | SqlDbType.Decimal
                SqlDbType.Decimal,
            108 => // 108 | "numeric" | SqlDbType.Decimal
                SqlDbType.Decimal,
            122 => // 122 | "smallmoney" | SqlDbType.SmallMoney
                SqlDbType.SmallMoney,
            127 => // 127 | "bigint" | SqlDbType.BigInt
                SqlDbType.BigInt,
            165 => // 165 | "varbinary" | SqlDbType.VarBinary
                SqlDbType.VarBinary,
            167 => // 167 | "varchar" | SqlDbType.VarChar
                SqlDbType.VarChar,
            173 => // 173 | "binary" | SqlDbType.Binary
                SqlDbType.Binary,
            175 => // 175 | "char" | SqlDbType.Char
                SqlDbType.Char,
            189 => // 189 | "timestamp" | SqlDbType.Timestamp
                SqlDbType.Timestamp,
            231 => // 231 | "nvarchar", "sysname" | SqlDbType.NVarChar
                SqlDbType.NVarChar,
            239 => // 239 | "nchar" | SqlDbType.NChar
                SqlDbType.NChar,
            240 => // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                SqlDbType.Udt,
            241 => // 241 | "xml" | SqlDbType.Xml
                SqlDbType.Xml,
            _ => throw new Exception(string.Format(
                "Unsupported Type: {0}. Please let us know about this type and we will support it: sales@zzzprojects.com",
                @this))
        };
    }
}