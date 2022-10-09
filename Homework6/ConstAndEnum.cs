using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public enum CtrlTargetSql
    {
        College = 0,
        Class = 1,
        Student = 2,
        SQLitLog = 3
    }

    public static class SqlTable
    {
        public static readonly string College = "college";
        public static readonly string Class = "class";
        public static readonly string Student = "student";
        public static readonly string SQLiteLog = "sqlitelog";
    }
}
