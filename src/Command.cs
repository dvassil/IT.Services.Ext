using System.Data;
using System.Data.Common;

namespace IT.Services.Ext
{
    public static class Command
    {
        public static void AddParameter(this IDbCommand cmd, string name,
                                        DbType type, object value)
        {
            cmd.Parameters.Add(cmd.CreateParameter(name, type, ParameterDirection.Input, value));
        }

        public static void AddParameter(this IDbCommand cmd, string name,
                                        DbType type, ParameterDirection direction,
                                        object value)
        {
            cmd.Parameters.Add(cmd.CreateParameter(name, type, direction, value));
        }

        public static void AddParameter(this DbCommand cmd, string name,
                                        DbType type, object value)
        {
            cmd.Parameters.Add(cmd.CreateParameter(name, type, ParameterDirection.Input, value));
        }

        public static void AddParameter(this DbCommand cmd, string name,
                                        DbType type, ParameterDirection direction,
                                        object value)
        {
            cmd.Parameters.Add(cmd.CreateParameter(name, type, direction, value));
        }

        public static void AddParameter(this DbCommand cmd, string name,
                                        DbType type, ParameterDirection direction,
                                        object value, bool nullable)
        {
            DbParameter param = cmd.CreateParameter(name, type, direction, value);
            param.IsNullable = true;
            cmd.Parameters.Add(param);
        }

        public static IDbDataParameter CreateParameter(this IDbCommand cmd, string name,
                                                       DbType type, ParameterDirection direction,
                                                       object value)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = name;
            param.DbType = type;
            param.Direction = direction;
            param.Value = value;

            return param;
        }

        public static IDbDataParameter CreateParameter(this IDbCommand cmd, string name,
                                                       DbType type, object value)
        {
            return cmd.CreateParameter(name, type, ParameterDirection.Input, value);
        }

        public static DbParameter CreateParameter(this DbCommand cmd, string name,
                                                  DbType type, ParameterDirection direction,
                                                  object value)
        {
            DbParameter param = cmd.CreateParameter();
            param.ParameterName = name;
            param.DbType = type;
            param.Direction = direction;
            param.Value = value;

            return param;
        }

        public static DbParameter CreateParameter(this DbCommand cmd, string name,
                                                  DbType type, object value)
        {
            return cmd.CreateParameter(name, type, ParameterDirection.Input, value);
        }
    }
}