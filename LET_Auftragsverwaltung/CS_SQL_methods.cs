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

        static public DataTable Fill_Box(string sql)
        {

            var da = new OdbcDataAdapter(sql, Connection);
            var dt_out = new DataTable();
            da.Fill(dt_out);

            return dt_out;
        }

        static public void SQL_exec(string sql)
        {
            Open();
            var cmd = new OdbcCommand(sql, Connection);
            cmd.ExecuteNonQuery();
            

        }


        /// <summary>
        /// Benützen um Connection zu öffnen
        /// Wenn NUR diese Methode zum öffnen benützt wird braucht man KEIN Close mehr!
        /// </summary>
        static public void Open( )
        {
            Connection.Close();
            Connection.Open();
        }
    }
}
