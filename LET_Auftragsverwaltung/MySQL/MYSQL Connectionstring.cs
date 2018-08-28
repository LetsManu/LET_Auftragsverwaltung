//"Driver={MySQL ODBC 3.51 Driver};Server=192.168.16.192;Database=auftrags;User=admin;Password=cola0815;Option=3;"



private OdbcConnection connection = null;

private OdbcConnection Connection
{
    get
    {
        if (connection == null)
        {
            string constrg = "Driver={MySQL ODBC 3.51 Driver};Server=192.168.16.192;Database=auftrags;User=admin;Password=cola0815;Option=3;";
            connection = new OdbcConnection(constrg);
        }
        return connection;
    }
}


//Verbindung �ffnen
Connection.Open();
//Daten Lesen / Schreiben
string sql = "SELECT * FROM tab_Land ORDER BY Bezeichnung";
OdbcCommand cmd = new OdbcCommand(sql, Connection);
OdbcDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    lBx_Laender.Items.Add(reader["Bezeichnung"]);
}
//Datenbank schlie�en
Connection.Close();



sql = "SELECT LID,Bezeichnung FROM tab_Land ORDER BY Bezeichnung";
OdbcDataAdapter da = new OdbcDataAdapter(sql, connection);
DataTable dtLaender = new DataTable();
da.Fill(dtLaender);
lBx_Land_ID.DisplayMember = "Bezeichnung";
lBx_Land_ID.ValueMember = "LID";
lBx_Land_ID.DataSource = dtLaender;