using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LET_Auftragsverwaltung
{

    class SQL_methods
    {

        static private OdbcConnection Connection => DB.Connection;

        /// <summary>
        /// Fill DataTables with returnvalues of SQL command
        /// </summary>
        /// <param name="sql">sql command</param>
        /// <returns>Datatable with the returnvalues the sql command</returns>
        static public DataTable Fill_Box(string sql)
        {

            var da = new OdbcDataAdapter(sql, Connection);
            var dt_out = new DataTable();
            da.Fill(dt_out);

            return dt_out;
        }

        /// <summary>
        /// Executes SQL command, use of Con.open is not required.
        /// </summary>
        /// <param name="sql">sql command</param>
        static public void SQL_exec(string sql)
        {
            Open();
            var cmd = new OdbcCommand(sql, Connection);
            cmd.ExecuteNonQuery();
            

        }


        /// <summary>
        /// Used to open the Connection, without needing to close it.
        /// Only uses it when it doesn't matter if the Connection is longer opened than needed
        /// </summary>
        static public void Open( )
        {
            Connection.Close(); 
            //TODO Connection.State
            Connection.Open();
        }
    }
}
