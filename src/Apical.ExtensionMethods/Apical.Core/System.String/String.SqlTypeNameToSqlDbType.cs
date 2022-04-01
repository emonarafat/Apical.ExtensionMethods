#region License

// // Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// // Issues: https://github.com/emonarafat/Apical.ExtensionMethods/issues
// // License (MIT): https://github.com/emonarafat/Apical.ExtensionMethods/blob/master/LICENSE
// 
// // Copyright © Apical Automates Inc. All rights reserved.

#endregion

using System;
using System.Data;

public static partial class Extensions
{
    public static SqlDbType SqlTypeNameToSqlDbType(this string @this)
    {
        return @this.ToLower() switch
        {
            "image" => // 34 | "image" | SqlDbType.Image
                SqlDbType.Image,
            "text" => // 35 | "text" | SqlDbType.Text
                SqlDbType.Text,
            "uniqueidentifier" => // 36 | "uniqueidentifier" | SqlDbType.UniqueIdentifier
                SqlDbType.UniqueIdentifier,
            "date" => // 40 | "date" | SqlDbType.Date
                SqlDbType.Date,
            "time" => // 41 | "time" | SqlDbType.Time
                SqlDbType.Time,
            "datetime2" => // 42 | "datetime2" | SqlDbType.DateTime2
                SqlDbType.DateTime2,
            "datetimeoffset" => // 43 | "datetimeoffset" | SqlDbType.DateTimeOffset
                SqlDbType.DateTimeOffset,
            "tinyint" => // 48 | "tinyint" | SqlDbType.TinyInt
                SqlDbType.TinyInt,
            "smallint" => // 52 | "smallint" | SqlDbType.SmallInt
                SqlDbType.SmallInt,
            "int" => // 56 | "int" | SqlDbType.Int
                SqlDbType.Int,
            "smalldatetime" => // 58 | "smalldatetime" | SqlDbType.SmallDateTime
                SqlDbType.SmallDateTime,
            "real" => // 59 | "real" | SqlDbType.Real
                SqlDbType.Real,
            "money" => // 60 | "money" | SqlDbType.Money
                SqlDbType.Money,
            "datetime" => // 61 | "datetime" | SqlDbType.DateTime
                SqlDbType.DateTime,
            "float" => // 62 | "float" | SqlDbType.Float
                SqlDbType.Float,
            "sql_variant" => // 98 | "sql_variant" | SqlDbType.Variant
                SqlDbType.Variant,
            "ntext" => // 99 | "ntext" | SqlDbType.NText
                SqlDbType.NText,
            "bit" => // 104 | "bit" | SqlDbType.Bit
                SqlDbType.Bit,
            "decimal" => // 106 | "decimal" | SqlDbType.Decimal
                SqlDbType.Decimal,
            "numeric" => // 108 | "numeric" | SqlDbType.Decimal
                SqlDbType.Decimal,
            "smallmoney" => // 122 | "smallmoney" | SqlDbType.SmallMoney
                SqlDbType.SmallMoney,
            "bigint" => // 127 | "bigint" | SqlDbType.BigInt
                SqlDbType.BigInt,
            "varbinary" => // 165 | "varbinary" | SqlDbType.VarBinary
                SqlDbType.VarBinary,
            "varchar" => // 167 | "varchar" | SqlDbType.VarChar
                SqlDbType.VarChar,
            "binary" => // 173 | "binary" | SqlDbType.Binary
                SqlDbType.Binary,
            "char" => // 175 | "char" | SqlDbType.Char
                SqlDbType.Char,
            "timestamp" => // 189 | "timestamp" | SqlDbType.Timestamp
                SqlDbType.Timestamp,
            "nvarchar" => // 231 | "nvarchar", "sysname" | SqlDbType.NVarChar
                SqlDbType.NVarChar,
            "sysname" => // 231 | "nvarchar", "sysname" | SqlDbType.NVarChar
                SqlDbType.NVarChar,
            "nchar" => // 239 | "nchar" | SqlDbType.NChar
                SqlDbType.NChar,
            "hierarchyid" => // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                SqlDbType.Udt,
            "geometry" => // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                SqlDbType.Udt,
            "geography" => // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                SqlDbType.Udt,
            "xml" => // 241 | "xml" | SqlDbType.Xml
                SqlDbType.Xml,
            _ => throw new Exception(string.Format(
                "Unsupported Type: {0}. Please let us know about this type and we will support it: sales@zzzprojects.com",
                @this))
        };
    }
}