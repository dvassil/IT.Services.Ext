using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace IT.Services.Ext
{
    public static class Ext
    {
        #region object Extensions

        public static int ToInt(this object obj) { return Convert.ToInt32(obj); }

        public static bool ToBoolean(this object obj) { return Convert.ToBoolean(obj); }

        public static DateTime ToDateTime(this object obj) { return Convert.ToDateTime(obj); }

        public static float ToFloat(this object obj) { return (float)Convert.ToDouble(obj); }

        public static double ToDouble(this object obj) { return Convert.ToDouble(obj); }

        public static decimal ToDecimal(this object obj) { return Convert.ToDecimal(obj); }

        #endregion object Extensions

        #region DataRow Extensions

        public static T GetValue<T>(this DataRow dr, string column) { return (T)dr[column]; }

        public static void GetValue(this DataRow dr, string column, out int? field)
        {
            if ((dr[column] == DBNull.Value) || (dr[column] == null))
                field = null;
            else
                field = Convert.ToInt32(dr[column]);
        }

        public static void GetValue(this DataRow dr, string column, out int field)
        {
            field = Convert.ToInt32(dr[column]);
        }

        public static void GetValue(this DataRow dr, string column, out string field)
        {
            field = Convert.ToString(dr[column]);
        }

        public static void GetValue(this DataRow dr, string column, out bool field)
        {
            field = Convert.ToBoolean(dr[column]);
        }

        public static void GetValue(this DataRow dr, string column, out System.DateTime field)
        {
            field = Convert.ToDateTime(dr[column]);
        }

        public static void GetValue(this DataRow dr, string column, out double field)
        {
            field = Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this DataRow dr, string column, out float field)
        {
            field = (float)Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this DataRow dr, string column, out decimal field)
        {
            field = Convert.ToDecimal(dr[column]);
        }

        public static T GetValue<T>(this DataRow dr, int column) { return (T)dr[column]; }

        public static void GetValue(this DataRow dr, int column, out int field)
        {
            field = Convert.ToInt32(dr[column]);
        }

        public static void GetValue(this DataRow dr, int column, out string field)
        {
            field = Convert.ToString(dr[column]);
        }

        public static void GetValue(this DataRow dr, int column, out bool field)
        {
            field = Convert.ToBoolean(dr[column]);
        }

        public static void GetValue(this DataRow dr, int column, out System.DateTime field)
        {
            field = Convert.ToDateTime(dr[column]);
        }

        public static void GetValue(this DataRow dr, int column, out double field)
        {
            field = Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this DataRow dr, int column, out float field)
        {
            field = (float)Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this DataRow dr, int column, out decimal field)
        {
            field = Convert.ToDecimal(dr[column]);
        }

        #endregion DataRow Extensions

        #region DbDataReader Extensions

        public static T GetValue<T>(this DbDataReader dr, string column) { return (T)dr[column]; }

        public static void GetValue(this DbDataReader dr, string column, out int field)
        {
            field = Convert.ToInt32(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, string column, out int? field)
        {
            if ((dr[column] == DBNull.Value) || (dr[column] == null))
                field = null;
            else
                field = Convert.ToInt32(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, string column, out string field)
        {
            field = Convert.ToString(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, string column, out bool field)
        {
            field = Convert.ToBoolean(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, string column, out System.DateTime field)
        {
            field = Convert.ToDateTime(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, string column, out double field)
        {
            field = Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, string column, out float field)
        {
            field = (float)Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, string column, out decimal field)
        {
            field = Convert.ToDecimal(dr[column]);
        }

        public static T GetValue<T>(this DbDataReader dr, int column) { return (T)dr[column]; }

        public static void GetValue(this DbDataReader dr, int column, out int field)
        {
            field = Convert.ToInt32(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, int column, out string field)
        {
            field = Convert.ToString(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, int column, out bool field)
        {
            field = Convert.ToBoolean(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, int column, out System.DateTime field)
        {
            field = Convert.ToDateTime(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, int column, out double field)
        {
            field = Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, int column, out float field)
        {
            field = (float)Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this DbDataReader dr, int column, out decimal field)
        {
            field = Convert.ToDecimal(dr[column]);
        }

        #endregion DbDataReader Extensions

        #region IDataReader Extensions

        public static T GetValue<T>(this IDataReader dr, string column) { return (T)dr[column]; }

        public static void GetValue(this IDataReader dr, string column, out short field)
        {
            field = Convert.ToInt16(dr[column]);
        }

        public static void GetValue(this IDataReader dr, string column, out int field)
        {
            field = Convert.ToInt32(dr[column]);
        }

        public static void GetValue(this IDataReader dr, string column, out string field)
        {
            field = Convert.ToString(dr[column]);
        }

        public static void GetValue(this IDataReader dr, string column, out bool field)
        {
            field = Convert.ToBoolean(dr[column]);
        }

        public static void GetValue(this IDataReader dr, string column, out System.DateTime field)
        {
            field = Convert.ToDateTime(dr[column]);
        }

        public static void GetValue(this IDataReader dr, string column, out double? field)
        {
            object obj = dr[column];
            if (obj == DBNull.Value)
                field = null;
            else
                field = Convert.ToDouble(obj);
        }

        public static void GetValue(this IDataReader dr, string column, out double field)
        {
            field = Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this IDataReader dr, string column, out float field)
        {
            field = (float)Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this IDataReader dr, string column, out decimal field)
        {
            field = Convert.ToDecimal(dr[column]);
        }

        public static T GetValue<T>(this IDataReader dr, int column) { return (T)dr[column]; }

        public static void GetValue(this IDataReader dr, int column, out int field)
        {
            field = Convert.ToInt32(dr[column]);
        }

        public static void GetValue(this IDataReader dr, int column, out string field)
        {
            field = Convert.ToString(dr[column]);
        }

        public static void GetValue(this IDataReader dr, int column, out bool field)
        {
            field = Convert.ToBoolean(dr[column]);
        }

        public static void GetValue(this IDataReader dr, int column, out System.DateTime field)
        {
            field = Convert.ToDateTime(dr[column]);
        }

        public static void GetValue(this IDataReader dr, int column, out double field)
        {
            field = Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this IDataReader dr, int column, out float field)
        {
            field = (float)Convert.ToDouble(dr[column]);
        }

        public static void GetValue(this IDataReader dr, int column, out decimal field)
        {
            field = Convert.ToDecimal(dr[column]);
        }

        #endregion IDataReader Extensions

    }
}
