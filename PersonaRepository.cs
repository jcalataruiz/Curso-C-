
using MySql.Data.MySqlClient;

namespace net1;


    public class PersonaRepository
    {
        public List<Persona> obtenerPersonas()
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
            // ConexionDB db=new ConexionDB();
            // var conn=db.ObtenerConexion();
            var comando=conn.CreateCommand();
            comando.CommandText= "select * from personas";  
            var reader=comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<Persona> lista=new List<Persona>();
            while (reader.Read())
            {
                Persona p=new Persona(reader.GetString("nombre"),reader.GetString("apellidos"),reader.GetString("dni"));
                lista.Add(p);
            }
            return lista;
        }
        public List<Persona> obtenerPersonasPorOrdenadasPorNombre()
        {
            
            ConexionDB db=new ConexionDB();
            var conn=db.ObtenerConexion();
            var comando=conn.CreateCommand();
            comando.CommandText= "select * from personas order by nombre";  
            var reader=comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<Persona> lista=new List<Persona>();
            while (reader.Read())
            {
                Persona p=new Persona(reader.GetString("nombre"),reader.GetString("apellidos"),reader.GetString("dni"));
                lista.Add(p);
            }
            return lista;
        }
        public List<Persona> buscarPersonaPorNombre(string nombre)
        {
            
            ConexionDB db=new ConexionDB();
            var conn=db.ObtenerConexion();
            var comando=conn.CreateCommand();
            comando.CommandText= "select * from personas where nombre ='"+nombre+"'";  
            var reader=comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            List<Persona> lista=new List<Persona>();
            while (reader.Read())
            {
                Persona p=new Persona(reader.GetString("nombre"),reader.GetString("apellidos"),reader.GetString("dni"));
                lista.Add(p);
            }
            return lista;
        }
        public void insertarPersona(Persona persona){
            ConexionDB db=new ConexionDB();
            var conn=db.ObtenerConexion();
            var comando=conn.CreateCommand();
            comando.CommandText= "insert into personas values ('"+persona.Dni+"','"+persona.Nombre+"','"+persona.Apellidos+"')";
            comando.ExecuteNonQuery();
        }
        public void borrarPersona(string dni){
            ConexionDB db=new ConexionDB();
            var conn=db.ObtenerConexion();
            var comando=conn.CreateCommand();
            comando.CommandText= "delete from personas where dni='"+dni+"'";
            comando.ExecuteNonQuery();
        }

        public void modificarPersona(Persona p, string dni){
            ConexionDB db=new ConexionDB();
            var conn=db.ObtenerConexion();
            var comando=conn.CreateCommand();
            comando.CommandText= "UPDATE `personas` SET `DNI`='"+p.Dni+"',`nombre`='"+p.Nombre+"',`apellidos`='"+p.Apellidos+"' WHERE DNI = '"+dni+"'";
            comando.ExecuteNonQuery();
        }
    }



