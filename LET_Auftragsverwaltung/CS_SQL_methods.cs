using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LET_Auftragsverwaltung
{

    class CS_SQL_methods
    {

        static private OdbcConnection Connection => CS_DB.Connection;

        static public DataTable Fill_CBX(string sql)
        {

            var da = new OdbcDataAdapter(sql, Connection);
            var dt_out = new DataTable();
            da.Fill(dt_out);
            Connection.Close();

            return dt_out;
        }
    }
}
