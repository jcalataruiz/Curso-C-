using MySql.Data.MySqlClient;

namespace net1;

public class ConexionDB
{
public MySqlConnection ObtenerConexion()
    {
        var sb = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "",
            Port = 3306,
            Database = "cursosantander"

        };
        MySqlConnection conn = new MySqlConnection(sb.ConnectionString);
        conn.Open();
        return conn;
    }
}