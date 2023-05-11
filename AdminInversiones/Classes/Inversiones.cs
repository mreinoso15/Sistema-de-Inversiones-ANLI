using System;


namespace AdminInversiones
{
    public class Inversiones
    {
        public int NoSocio { get; set; }
        public int solicitudInv { get; set; }
        public string Socio { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }    
        public double Tasa { get; set; }

    }

    public class Retiros
    {
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public int IdDeposito { get; set; }
        public double Cantidad { get; set; }
        public DateTime FechaAprob { get; set; }
        public double Tasa { get; set; }
    }

    public class Tasa
    {

    }
}
