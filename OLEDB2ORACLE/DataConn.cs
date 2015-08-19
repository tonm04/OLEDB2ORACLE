using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using System.Data.OracleClient;
namespace Maticsoft.DBUtility
{

    /// <summary>
    ///DataConn 的摘要说明
    /// </summary>
    public static class DataConn
    {
        //public DataConn()
        //{
        //    //
        //    //TODO: 在此处添加构造函数逻辑
        //    //
        //}


        public static void MyExecuteNonQuery(string DBTag, string sql)
        {
            DbHelperOra.ExecuteSql(sql);
        }

        public static DataSet MyExecuteDataSet(string DBTag, string sql)
        {
            return DbHelperOra.Query(sql);
        }

        public static void MyExecuteNonQueryClob(string DBTag, string sql, ArrayList ParamNames, ArrayList ParamValues)
        {
            DbHelperOra.MyExecuteNonQueryClob(sql, ParamNames, ParamValues);
        }
         
        public static void MyExecute_Proc_ReturnParam(string DBTag, string proc_name, string proc_para, string param_name)
        {
            OracleParameter[] parameters = {
                new OracleParameter("mission_id", OracleType.VarChar),
                new OracleParameter("oprate_mode",OracleType.VarChar),
                new OracleParameter("session_username", OracleType.VarChar),
                new OracleParameter("str_sid", OracleType.VarChar),
                new OracleParameter("paramout", OracleType.Cursor, 2000, ParameterDirection.Output, true, 0, 0, "",
                DataRowVersion.Default, Convert.DBNull)
};
            parameters[0].Value = proc_para.Split('*')[0];
            parameters[1].Value = proc_para.Split('*')[1];
            parameters[2].Value = proc_para.Split('*')[2];
            parameters[3].Value = proc_para.Split('*')[3];

            DbHelperOra.RunProcedure(proc_name, parameters, "RESU");
        }
         
    }
}