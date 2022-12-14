namespace net1 {
    public class Factura
    {
        public Factura(int numero, string concepto, double importe, string empresa, DateTime fecha)
        {
            this.numero = numero;
            this.concepto = concepto;
            this.importe = importe;
            this.empresa = empresa;
            this.fecha = fecha;
        }
        public Factura(int numero, string concepto, double importe, string empresa)
        {
            this.numero = numero;
            this.concepto = concepto;
            this.importe = importe;
            this.empresa = empresa;
            
        }

        public int numero {get;set;}
        public string concepto {get;set;}
        public double importe {get;set;}
        public string empresa {get;set;}
        public DateTime fecha{get;set;}
    }
}