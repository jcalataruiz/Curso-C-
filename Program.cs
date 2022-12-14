namespace net1
{

    class Program
    {

        static void Main(string[] args)
        {
            PersonaRepository repo = new PersonaRepository();

            // List<Persona> lista = repo.obtenerPersonas();
            // List<Persona> lista2 = repo.obtenerPersonasPorOrdenadasPorNombre();
            // List<Persona> lista3 = repo.buscarPersonaPorNombre("Pedro");

            // foreach (var persona in lista3)
            // {
            //     Console.WriteLine(persona.Nombre + " " + persona.Apellidos + " " + persona.Dni);
            // }
            // Console.WriteLine(".........");
            // Console.WriteLine(".........");
            // Console.WriteLine(".........");
            // foreach (var persona in lista2)
            // {
            //     Console.WriteLine(persona.Nombre + " " + persona.Apellidos + " " + persona.Dni);
            // }
            // Console.WriteLine("Funcionando!!!!");

            // FacturaRepository fr=new FacturaRepository();
            // List<Factura>facturas=fr.obtenerFacturas();
            // foreach (var factura in facturas)
            // {
            //     Console.WriteLine(factura.concepto+" "+factura.importe+" "+factura.fecha);
            // }
            

            List<Persona> lista4 = repo.obtenerPersonas();
            foreach (var persona in lista4)
            {
                Console.WriteLine(persona.Nombre + " " + persona.Apellidos + " " + persona.Dni);
            }
            Persona nueva=new Persona("34","Pablo","Motos");
            repo.modificarPersona(nueva,"5");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            lista4 = repo.obtenerPersonas();
            foreach (var persona in lista4)
            {
                Console.WriteLine(persona.Nombre + " " + persona.Apellidos + " " + persona.Dni);
            }
        }




    }

}