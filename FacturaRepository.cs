
namespace net1;

public class FacturaRepository
{
    public List<Factura> obtenerFacturas(){
        ConexionDB db=new ConexionDB();
        var conn=db.ObtenerConexion();
        var comando=conn.CreateCommand();
        comando.CommandText="select * from facturas";
        var reader=comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        List<Factura> facturas=new List<Factura>();
        while (reader.Read()){
            Factura f=new Factura(reader.GetInt32("numero"),reader.GetString("concepto"),reader.GetInt32("importe"),
            reader.GetString("empresa"),reader.GetDateTime("fecha"));
            facturas.Add(f);
        }
        return facturas;
    }
}