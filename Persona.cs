
namespace net1
{
    public class Persona
    {


        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        

        public Persona(string nombre, string apellidos, string dni)
        {
            this.Dni=dni;
            this.Nombre=nombre;
            this.Apellidos=apellidos;
        }

    }

}