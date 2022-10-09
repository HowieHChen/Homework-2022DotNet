using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class SqlManager
    {
        public static void LoadFromSql(out DataTable collegeTable, out DataTable classTable, out DataTable stuTable, out DataTable logTable)
        {
            collegeTable = SQLiteHelper.ExecuteQuery($"SELECT * FROM {SqlTable.College}");
            classTable = SQLiteHelper.ExecuteQuery($"SELECT * FROM {SqlTable.Class}");
            stuTable = SQLiteHelper.ExecuteQuery($"SELECT * FROM {SqlTable.Student}");
            logTable = SQLiteHelper.ExecuteQuery($"SELECT * FROM {SqlTable.SQLiteLog}");
        }

        public static bool AddInfo(CtrlTargetSql sql, string[] param)
        {
            string sqlCmd;
            string sqlLog;
            string sqlCmdLog;
            switch (sql)
            {
                case CtrlTargetSql.College:
                    sqlCmd = $"REPLACE INTO {SqlTable.College} VALUES({param[0]},'{param[1]}')";
                    sqlLog = $"更新了表{SqlTable.College}中的数据({param[0]},{param[1]})";
                    break;
                case CtrlTargetSql.Class:
                    sqlCmd = $"REPLACE INTO {SqlTable.Class} VALUES({param[0]},'{param[1]}',{param[2]})";
                    sqlLog = $"更新了表{SqlTable.Class}中的数据({param[0]},{param[1]},{param[2]})";
                    break;
                case CtrlTargetSql.Student:
                    sqlCmd = $"REPLACE INTO {SqlTable.Student} VALUES({param[0]},'{param[1]}',{param[2]},{param[3]},{param[4]})";
                    sqlLog = $"更新了表{SqlTable.Student}中的数据({param[0]},{param[1]},{param[2]},{param[3]},{param[4]})";
                    break;
                default:
                    return false;
                    //break;
            }
            try
            {
                int result = SQLiteHelper.ExecuteNonQuery(sqlCmd);
                if (result > 0)
                {
                    long timeNow = NowTimestamp();
                    sqlCmdLog = $"REPLACE INTO {SqlTable.SQLiteLog} VALUES({timeNow},'{sqlLog}')";
                    SQLiteHelper.ExecuteNonQuery(sqlCmdLog);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }

        public static bool DelInfo(CtrlTargetSql sql, string[] param)
        {
            string sqlCmd;
            string sqlLog;
            string sqlCmdLog;
            switch (sql)
            {
                case CtrlTargetSql.College:
                    sqlCmd = $"DELETE FROM {SqlTable.College} WHERE CollegeId = {param[0]}";
                    sqlLog = $"从表{SqlTable.College}中删除了数据({param[0]})";
                    break;
                case CtrlTargetSql.Class:
                    sqlCmd = $"DELETE FROM {SqlTable.Class} WHERE ClassId = {param[0]} AND CollegeId = {param[1]}";
                    sqlLog = $"从表{SqlTable.Class}中删除了数据({param[0]},{param[1]})";
                    break;
                case CtrlTargetSql.Student:
                    sqlCmd = $"DELETE FROM {SqlTable.Student} WHERE StuId = {param[0]} AND CollegeId = {param[1]} AND ClassId = {param[2]}";
                    sqlLog = $"从表{SqlTable.College}中删除了数据({param[0]},{param[1]},{param[2]})";
                    break;
                default:
                    return false;
                    //break;
            }
            try
            {
                int result = SQLiteHelper.ExecuteNonQuery(sqlCmd);
                if (result > 0)
                {
                    long timeNow = NowTimestamp();
                    sqlCmdLog = $"REPLACE INTO {SqlTable.SQLiteLog} VALUES({timeNow},'{sqlLog}')";
                    SQLiteHelper.ExecuteNonQuery(sqlCmdLog);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
        
        public static long NowTimestamp()
        {
            return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        }

        public static DataRow[] RefreshLog()
        {
            return SQLiteHelper.ExecuteQuery($"SELECT * FROM {SqlTable.SQLiteLog}").Rows.Cast<DataRow>().ToArray();
        }
    }
}
